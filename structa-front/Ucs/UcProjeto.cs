using structa_front.Models;
using structa_front;
using structa_front.Services;
using System;
using System.ComponentModel; // Adicionado para ListSortDirection
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace structa_front
{
    public partial class UcPlanoDeGestao : UserControl
    {
        // Flag para controlar o estado de visibilidade do painel de tarefas
        private bool isPainelTarefasVisivel = true;

        // Declara o ContextMenuStrip para o filtro
        private ContextMenuStrip contextMenuFiltroStatus;

        // VVV NOVAS VARIÁVEIS DE ESTADO VVV
        private bool isSortAscending = true; // Para controlar a ordenação A-Z / Z-A
        private bool areCompletedTasksHidden = false; // Para controlar a ocultação
        private string filtroStatusAtual = "Todos"; // Para guardar o filtro atual
        // ^^^ NOVAS VARIÁVEIS DE ESTADO ^^^

        public UcPlanoDeGestao()
        {
            InitializeComponent();
        }

        private async void retornarTarefas()
        {
            var TarefasService = new Services.TarefasService();
            dgvTarefas.Rows.Clear();

            try
            {
                var listaTarefas = await TarefasService.ObterTarefasAsync(Sessao.UsuarioId, 1);

                // Update grid on UI thread
                if (InvokeRequired)
                {
                    Invoke(new Action(() => PreencherGridComTarefas(listaTarefas)));
                }
                else
                {
                    PreencherGridComTarefas(listaTarefas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter tarefas: " + ex.Message);
            }
        }

        // Helper: remove existing placeholder(s), add tarefas, then append a single placeholder row
        private void PreencherGridComTarefas(System.Collections.Generic.List<Tarefa> listaTarefas)
        {
            // Remove any existing placeholder rows (colTarefa == "+ Adicionar tarefa")
            for (int i = dgvTarefas.Rows.Count - 1; i >= 0; i--)
            {
                var val = dgvTarefas.Rows[i].Cells["colTarefa"].Value;
                if (val != null && val.ToString() == "+ Adicionar tarefa")
                {
                    dgvTarefas.Rows.RemoveAt(i);
                }
            }

            // Now append fetched tarefas
            if (listaTarefas != null)
            {
                foreach (var tarefa in listaTarefas)
                {
                    dgvTarefas.Rows.Add(false, tarefa.Id, tarefa.Titulo, tarefa.Responsavel, tarefa.Status, tarefa.PrazoFinalEntrega);
                }
            }

            // Finally, add a single placeholder row at the end
            int rowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            DataGridViewRow placeholderRow = dgvTarefas.Rows[rowIndex];
            placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;
            placeholderRow.Cells["colID"].ReadOnly = true;
            placeholderRow.Cells["colResp"].ReadOnly = true;
            placeholderRow.Cells["colStatus"].ReadOnly = true;
            placeholderRow.Cells["colData"].ReadOnly = true;
        }

        // Este método está correto (com ID e tamanho da Tarefa)
        private void ConfigurarColunasDataGridView()
        {
            dgvTarefas.Columns.Clear();

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
            { Name = "colCheck", HeaderText = "", Width = 30 };
            dgvTarefas.Columns.Add(checkColumn);

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            { Name = "colID", HeaderText = "ID", Width = 50 };
            dgvTarefas.Columns.Add(idColumn);

            DataGridViewTextBoxColumn tarefaColumn = new DataGridViewTextBoxColumn
            { Name = "colTarefa", HeaderText = "Tarefa", Width = 300 };
            dgvTarefas.Columns.Add(tarefaColumn);

            DataGridViewTextBoxColumn respColumn = new DataGridViewTextBoxColumn
            { Name = "colResp", HeaderText = "Resp.", Width = 100 };
            dgvTarefas.Columns.Add(respColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            { Name = "colStatus", HeaderText = "Status", Width = 100, FlatStyle = FlatStyle.Flat };
            statusColumn.Items.Add("Parado");
            statusColumn.Items.Add("Concluído");
            statusColumn.Items.Add("Em Andamento");
            statusColumn.Items.Add("Novo");
            dgvTarefas.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn
            { Name = "colData", HeaderText = "Data", Width = 100 };
            dgvTarefas.Columns.Add(dataColumn);

            // Coluna Excluir
            DataGridViewButtonColumn excluirColumn = new DataGridViewButtonColumn();
            excluirColumn.Name = "colExcluir";
            excluirColumn.HeaderText = "";
            excluirColumn.Text = "Excluir";
            excluirColumn.UseColumnTextForButtonValue = true;
            excluirColumn.Width = 80;
            dgvTarefas.Columns.Add(excluirColumn);
        }

        // Este método está correto (com dados de exemplo para ID)
        private void CarregarDadosDeExemplo()
        {
            // Reintroduz placeholder: última linha com campos readonly e texto cinza
            int rowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            DataGridViewRow placeholderRow = dgvTarefas.Rows[rowIndex];
            placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;

            placeholderRow.Cells["colID"].ReadOnly = true;
            placeholderRow.Cells["colResp"].ReadOnly = true;
            placeholderRow.Cells["colStatus"].ReadOnly = true;
            placeholderRow.Cells["colData"].ReadOnly = true;
        }

        // --- MÉTODOS DE UI PADRÃO (sem alterações) ---

        private void HeaderEsteMes_Click(object sender, EventArgs e)
        {
            isPainelTarefasVisivel = !isPainelTarefasVisivel;
            panelTarefasGrid.Visible = isPainelTarefasVisivel;
        }

      

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sem comportamento especial aqui; usamos CellContentClick para detectar o clique no placeholder
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Tabela selecionada."); }
        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Gráfico selecionada."); }
        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Calendário selecionada."); }
        private void kanbanToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Kanban selecionada."); }
        private void btnCriarElemento_Click(object sender, EventArgs e) { MessageBox.Show("Botão 'Criar Elemento' clicado."); }


        // ==========================================================
        // VVV NOVA SEÇÃO: ORDENAR TAREFAS VVV
        // ==========================================================

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Inverte a direção da ordenação
            isSortAscending = !isSortAscending;
            AplicarOrdenacao();
        }

        private void AplicarOrdenacao()
        {
            // Ordena o DataGridView pela coluna "colTarefa"
            ListSortDirection direction = isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            dgvTarefas.Sort(dgvTarefas.Columns["colTarefa"], direction);
        }


        // ==========================================================
        // VVV NOVA SEÇÃO: OCULTAR CONCLUÍDAS VVV
        // ==========================================================

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            // Inverte o estado
            areCompletedTasksHidden = !areCompletedTasksHidden;

            // Atualiza o texto do botão para refletir a próxima ação
            if (areCompletedTasksHidden)
            {
                btnOcultar.Text = "Mostrar Concluídas";
            }
            else
            {
                btnOcultar.Text = "Ocultar Concluídas";
            }

            // Aplica a lógica de visibilidade
            AtualizarVisibilidadeLinhas();
        }


        // ==========================================================
        // VVV SEÇÃO DE FILTRO (MODIFICADA) VVV
        // ==========================================================

        private void CriarMenuDeFiltro()
        {
            contextMenuFiltroStatus = new ContextMenuStrip();
            var opcoes = new[] { "Mostrar Todos", "Parado", "Concluído", "Em Andamento", "Novo" };

            foreach (string opcao in opcoes)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(opcao);
                item.Click += FiltroStatus_Click;
                contextMenuFiltroStatus.Items.Add(item);
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                contextMenuFiltroStatus.Show(btn, 0, btn.Height);
            }
        }

        private void FiltroStatus_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicado = sender as ToolStripMenuItem;
            if (itemClicado != null)
            {
                string statusFiltro = itemClicado.Text;

                // Atualiza a variável de estado do filtro
                filtroStatusAtual = (statusFiltro == "Mostrar Todos") ? "Todos" : statusFiltro;

                // Chama o método mestre que aplica AMBAS as lógicas
                AtualizarVisibilidadeLinhas();
            }
        }

        /// <summary>
        /// NOVO MÉTODO MESTRE
        /// Lógica que aplica o FILTRO DE STATUS e a OCULTAÇÃO DE CONCLUÍDAS
        /// </summary>
        private void AtualizarVisibilidadeLinhas()
        {
            // Itera por todas as linhas do DataGridView
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                // Garante que a linha placeholder "+ Adicionar tarefa" fique sempre visível
                if (row.Cells["colTarefa"].Value != null && row.Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
                {
                    row.Visible = true;
                    continue;
                }

                bool isVisible = true; // Começa assumindo que a linha é visível
                var statusDaLinha = (row.Cells["colStatus"].Value != null) ? row.Cells["colStatus"].Value.ToString() : "";

                // 2. Lógica de Filtro
                // Se o filtro NÃO for "Todos", verifica se a linha corresponde
                if (filtroStatusAtual != "Todos")
                {
                    if (!statusDaLinha.Equals(filtroStatusAtual, StringComparison.OrdinalIgnoreCase))
                    {
                        isVisible = false; // Não corresponde ao filtro, esconde
                    }
                }

                // 3. Lógica de Ocultar
                // Só executa se a linha AINDA estiver visível (passou no filtro)
                // E se a opção de ocultar estiver ativa
                if (isVisible && areCompletedTasksHidden)
                {
                    if (statusDaLinha == "Concluído")
                    {
                        isVisible = false; // É concluída E queremos ocultar, esconde
                    }
                }

                // 4. Aplica a decisão final
                row.Visible = isVisible;
            }
        }

        // Este método é referenciado pelo Designer, então precisamos dele aqui
        private void panelToolbar_Paint(object sender, PaintEventArgs e)
        {
            // Pode deixar em branco
        }
        private void UcPlanoDeGestao_Load(object sender, EventArgs e)
        {
            // Define as colunas do DataGridView
            ConfigurarColunasDataGridView();
            this.dgvTarefas.CellPainting += dgvTarefas_CellPainting;

            // Carrega dados de exemplo para visualização
            CarregarDadosDeExemplo();

            // 1. Cria o menu de filtro dinamicamente
            CriarMenuDeFiltro();
            retornarTarefas();

            // VVV ALTERAÇÃO AQUI VVV
            // 2. Adiciona os eventos de clique aos botões da barra de ferramentas
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // ^^^ ALTERAÇÃO AQUI ^^^

            // Add handler to disable ComboBox AutoComplete when editing in the DataGridView
            this.dgvTarefas.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvTarefas_EditingControlShowing);
        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Detecta clique no botão Excluir
            if (e.ColumnIndex >= 0 && dgvTarefas.Columns[e.ColumnIndex].Name == "colExcluir")
            {
                var row = dgvTarefas.Rows[e.RowIndex];

                // Impede excluir o placeholder
                var titulo = Convert.ToString(row.Cells["colTarefa"].Value);
                if (titulo == "+ Adicionar tarefa") return;

                // Obtém ID da tarefa
                if (int.TryParse(Convert.ToString(row.Cells["colID"].Value), out int idTarefa) && idTarefa > 0)
                {
                    var confirmar = MessageBox.Show(
                        "Deseja realmente excluir esta tarefa?",
                        "Confirmar exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmar == DialogResult.Yes)
                    {
                        ExcluirTarefa(idTarefa);
                    }
                }
                else
                {
                    // Se não tiver ID (ex: linha nova mal preenchida), apenas remove localmente
                    dgvTarefas.Rows.RemoveAt(e.RowIndex);
                }

                return; // Impede cair na lógica do "+ Adicionar tarefa"
            }

            // Proteções básicas
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var qtdLinhas = dgvTarefas.Rows.Count;

            // Só procede se clicou na última linha do grid
            if (e.RowIndex != qtdLinhas - 1) return;

            var cellValue = dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value;
            if (cellValue == null) return;

            if (cellValue.ToString() == "+ Adicionar tarefa")
            {
                // Transforma a linha placeholder em linha editável
                DataGridViewRow linhaAtual = dgvTarefas.Rows[e.RowIndex];
                linhaAtual.Cells["colTarefa"].Value = "";
                linhaAtual.DefaultCellStyle.ForeColor = Color.White;
                linhaAtual.Cells["colID"].ReadOnly = false;
                linhaAtual.Cells["colResp"].ReadOnly = false;
                linhaAtual.Cells["colStatus"].ReadOnly = false;
                linhaAtual.Cells["colData"].ReadOnly = false;
                // Remove setting of colID here so new task keeps empty ID and will be created
                // linhaAtual.Cells["colID"].Value = (dgvTarefas.Rows.Count - 1).ToString();
                dgvTarefas.CurrentCell = linhaAtual.Cells["colTarefa"];
                dgvTarefas.BeginEdit(true);

                // Adiciona um novo placeholder ao final (se não existir já)

                //MessageBox.Show("asidhjasgdh");
                bool hasPlaceholder = false;
                if (dgvTarefas.Rows.Count > 0)
                {
                    var lastRow = dgvTarefas.Rows[dgvTarefas.Rows.Count - 1];
                    var lastVal = lastRow.Cells["colTarefa"].Value?.ToString() ?? string.Empty;
                    hasPlaceholder = lastVal == "+ Adicionar tarefa";
                }

                if (!hasPlaceholder)
                {
                    int newRowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
                    DataGridViewRow placeholderRow = dgvTarefas.Rows[newRowIndex];
                    placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;
                    placeholderRow.Cells["colID"].ReadOnly = true;
                    placeholderRow.Cells["colResp"].ReadOnly = true;
                    placeholderRow.Cells["colStatus"].ReadOnly = true;
                    placeholderRow.Cells["colData"].ReadOnly = true;
                }
            }
        }
        private void dgvTarefas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Se não é a coluna do botão Excluir, sai
            if (dgvTarefas.Columns[e.ColumnIndex].Name != "colExcluir")
                return;

            var titulo = Convert.ToString(dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value);

            // Se for a linha "+ Adicionar tarefa", impede o desenho do botão
            if (titulo == "+ Adicionar tarefa")
            {
                e.PaintBackground(e.CellBounds, true); // só pinta o fundo
                e.Handled = true; // cancela o botão
                return;
            }

            // Caso contrário, desenha normalmente
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            e.Handled = true;
        }

        private void panelHeaderEsteMes_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var qtdLinhas = dgvTarefas.Rows.Count;

            // Get the row that was edited (the one before the placeholder)
            int targetRowIndex = Math.Max(0, qtdLinhas - 2);
            var row = dgvTarefas.Rows[targetRowIndex];

            // Ignore if this is the placeholder row
            var tarefaTitulo = Convert.ToString(row.Cells["colTarefa"].Value) ?? string.Empty;
            if (string.IsNullOrWhiteSpace(tarefaTitulo) || tarefaTitulo == "+ Adicionar tarefa")
            {
                return;
            }

            // Try to read existing ID from grid (if user was editing an existing task)
            int existingId = 0;
            var idCellVal = row.Cells["colID"].Value;
            if (idCellVal != null)
            {
                int.TryParse(Convert.ToString(idCellVal), out existingId);
            }

            var tarefa = new Models.Tarefa
            {
                Id = existingId,
                IdProjeto = 1, // TODO: replace with selected project id
                IdUsuario = Sessao.UsuarioId, // use current session user
                Titulo = tarefaTitulo,
                Responsavel = Convert.ToString(row.Cells["colResp"].Value) ?? string.Empty,
                Status = Convert.ToString(row.Cells["colStatus"].Value) ?? string.Empty,
                PrazoFinalEntrega = Convert.ToString(row.Cells["colData"].Value) ?? string.Empty,
            };

            var tarefasService = new Services.TarefasService();

            try
            {
                // Validate user exists to avoid FK violation
                var usuariosService = new Services.UsuariosService();
                var usuario = await usuariosService.BuscarUsuarioPorIdAsync(tarefa.IdUsuario);
                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado. Verifique se você está logado ou se o usuário existe antes de criar a tarefa.");
                    return;
                }

                // Optionally validate project exists (if IdProjeto comes from UI)
                var projetosService = new Services.ProjetosService();
                var projeto = await projetosService.BuscarProjetoPorIdAsync(tarefa.IdProjeto);
                if (projeto == null)
                {
                    MessageBox.Show("Projeto não encontrado. Verifique o ID do projeto antes de criar a tarefa.");
                    return;
                }

                if (tarefa.Id > 0)
                {
                    // update existing task
                    await tarefasService.AtualizarTarefas(tarefa);
                }
                else
                {
                    // criar tarefa
                    var criada = await tarefasService.CriarTarefaAsync(tarefa);
                    if (criada != null)
                    {
                        // update grid row id with created id
                        row.Cells["colID"].Value = criada.Id.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar tarefa: " + ex.Message);
            }
        }
        private async void ExcluirTarefa(int idTarefa)
        {
            try
            {
                var tarefasService = new Services.TarefasService();
                await tarefasService.DeletarTarefaAsync(idTarefa);

                // Atualiza o grid automaticamente
                retornarTarefas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir tarefa: " + ex.Message);
            }
        }

        private void btnFiltro_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            FrmPessoasCadastradas formPessoas = new FrmPessoasCadastradas();
            formPessoas.Show();
        }

        // Disable AutoComplete on ComboBox editing control to avoid OLE/STA ThreadStateException
        private void dgvTarefas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox combo)
            {
                try
                {
                    combo.AutoCompleteMode = AutoCompleteMode.None;
                    combo.AutoCompleteSource = AutoCompleteSource.None;
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch
                {
                    // Ignore any controls that don't support these properties
                }
            }
        }
    }
}