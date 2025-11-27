using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel; // Adicionado para ListSortDirection

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

        private void UcPlanoDeGestao_Load(object sender, EventArgs e)
        {
            // Define as colunas do DataGridView
            ConfigurarColunasDataGridView();

            // Carrega dados de exemplo para visualização
            CarregarDadosDeExemplo();

            // 1. Cria o menu de filtro dinamicamente
            CriarMenuDeFiltro();

            // VVV ALTERAÇÃO AQUI VVV
            // 2. Adiciona os eventos de clique aos botões da barra de ferramentas
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // ^^^ ALTERAÇÃO AQUI ^^^
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
        }

        // Este método está correto (com dados de exemplo para ID)
        private void CarregarDadosDeExemplo()
        {
            dgvTarefas.Rows.Add(false, "1", "[Exemplo] Reunião Mensal", "Ana", "Parado", "25/11");
            dgvTarefas.Rows.Add(true, "2", "[Exemplo] Relatório Semanal", "Bruno", "Concluído", "24/11");
            dgvTarefas.Rows.Add(false, "3", "[Exemplo] Teste de UI", "Carla", "Em Andamento", "26/11");
            dgvTarefas.Rows.Add(false, "4", "[Exemplo] Deploy", "Ana", "Novo", "27/11");
            dgvTarefas.Rows.Add(true, "5", "[Exemplo] Rever Docs", "Bruno", "Concluído", "22/11"); // Mais um concluído

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

        private void btnVisualizacoes_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                contextMenuStripVisualizacoes.Show(btn, 0, btn.Height);
            }
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
            {
                DataGridViewRow linhaAtual = dgvTarefas.Rows[e.RowIndex];
                linhaAtual.Cells["colTarefa"].Value = "";
                linhaAtual.DefaultCellStyle.ForeColor = Color.White;
                linhaAtual.Cells["colID"].ReadOnly = false;
                linhaAtual.Cells["colResp"].ReadOnly = false;
                linhaAtual.Cells["colStatus"].ReadOnly = false;
                linhaAtual.Cells["colData"].ReadOnly = false;
                linhaAtual.Cells["colID"].Value = (dgvTarefas.Rows.Count - 1).ToString();
                dgvTarefas.CurrentCell = linhaAtual.Cells["colTarefa"];
                dgvTarefas.BeginEdit(true);

                int newRowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
                DataGridViewRow placeholderRow = dgvTarefas.Rows[newRowIndex];
                placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;
                placeholderRow.Cells["colID"].ReadOnly = true;
                placeholderRow.Cells["colResp"].ReadOnly = true;
                placeholderRow.Cells["colStatus"].ReadOnly = true;
                placeholderRow.Cells["colData"].ReadOnly = true;
            }
        }

        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Tabela selecionada."); }
        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Gráfico selecionado."); }
        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Calendário selecionado."); }
        private void kanbanToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show("Visualização: Kanban selecionado."); }
        private void btnCriarElemento_Click(object sender, EventArgs e) { MessageBox.Show("Botão 'Criar Elemento' clicado."); }
        private void btnAdicionarGrupo_Click(object sender, EventArgs e) { MessageBox.Show("Botão 'Adicionar novo grupo' clicado."); }

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
            DataGridViewRow placeholderRow = null;

            // 1. Encontra e remove a linha "+ Adicionar tarefa"
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                if (row.Cells["colTarefa"].Value != null && row.Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
                {
                    placeholderRow = row;
                    dgvTarefas.Rows.Remove(row);
                    break;
                }
            }

            // 2. Define a direção da ordenação
            ListSortDirection direction = isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;

            // 3. Ordena o DataGridView pela coluna "colTarefa"
            dgvTarefas.Sort(dgvTarefas.Columns["colTarefa"], direction);

            // 4. Adiciona a linha placeholder de volta ao final
            if (placeholderRow != null)
            {
                dgvTarefas.Rows.Add(placeholderRow);
             
            
            }
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

            // Aplica a lógica de visibilidade (que agora inclui o filtro)
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
                // 1. Verifica se é a linha "+ Adicionar tarefa"
                // Esta linha deve SEMPRE estar visível.
                if (row.Cells["colTarefa"].Value != null && row.Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
                {
                    row.Visible = true;
                    continue; // Pula para a próxima linha
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
    }
}