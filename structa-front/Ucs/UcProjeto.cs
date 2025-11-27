// ==========================================================
// COLE ISTO EM: UcProjeto.cs
// ==========================================================
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace structa_front
{
    // A classe "partial" junta este arquivo com o Designer
    public partial class UcPlanoDeGestao : UserControl
    {
        // Flag para controlar o estado de visibilidade do painel de tarefas
        private bool isPainelTarefasVisivel = true;

        // Declara o ContextMenuStrip para o filtro
        private ContextMenuStrip contextMenuFiltroStatus;


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

            // 2. Adiciona o evento de clique ao botão Filtro
            // (Fazemos isso aqui em vez de no Designer)
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
        }

        /// <summary>
        /// ALTERAÇÃO: Adiciona Coluna ID e ajusta tamanho da Coluna Tarefa
        /// </summary>
        private void ConfigurarColunasDataGridView()
        {
            // Limpa colunas existentes, se houver
            dgvTarefas.Columns.Clear();

            // Coluna CheckBox
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
            {
                Name = "colCheck",
                HeaderText = "",
                Width = 30
            };
            dgvTarefas.Columns.Add(checkColumn);

            // Coluna ID (Texto)  <<< NOVA COLUNA ADICIONADA AQUI
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                Width = 50
            };
            dgvTarefas.Columns.Add(idColumn);

            // Coluna Tarefa (Texto)
            DataGridViewTextBoxColumn tarefaColumn = new DataGridViewTextBoxColumn
            {
                Name = "colTarefa",
                HeaderText = "Tarefa",
                // AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Removido
                Width = 300 // <<< TAMANHO DA TAREFA AJUSTADO
            };
            dgvTarefas.Columns.Add(tarefaColumn);

            // Coluna Responsável (Texto)
            DataGridViewTextBoxColumn respColumn = new DataGridViewTextBoxColumn
            {
                Name = "colResp",
                HeaderText = "Resp.",
                Width = 100
            };
            dgvTarefas.Columns.Add(respColumn);

            // Coluna Status (ComboBox)
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            {
                Name = "colStatus",
                HeaderText = "Status",
                Width = 100,
                FlatStyle = FlatStyle.Flat
            };
            statusColumn.Items.Add("Parado");
            statusColumn.Items.Add("Concluído");
            statusColumn.Items.Add("Em Andamento");
            statusColumn.Items.Add("Novo");
            dgvTarefas.Columns.Add(statusColumn);

            // Coluna Data (Texto)
            DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn
            {
                Name = "colData",
                HeaderText = "Data",
                Width = 100
            };
            dgvTarefas.Columns.Add(dataColumn);
        }

        /// <summary>
        /// ALTERAÇÃO: Adiciona dados para a nova coluna ID
        /// </summary>
        private void CarregarDadosDeExemplo()
        {
            // Adiciona linhas de exemplo
            // Formato: (check, ID, tarefa, resp, status, data)
            dgvTarefas.Rows.Add(false, "1", "[Exemplo] Reunião Mensal", "Ana", "Parado", "25/11");
            dgvTarefas.Rows.Add(true, "2", "[Exemplo] Relatório Semanal", "Bruno", "Concluído", "24/11");
            dgvTarefas.Rows.Add(false, "3", "[Exemplo] Teste de UI", "Carla", "Em Andamento", "26/11");
            dgvTarefas.Rows.Add(false, "4", "[Exemplo] Deploy", "Ana", "Novo", "27/11");

            // Linha para "Adicionar tarefa"
            // Formato: (check, ID, tarefa, resp, status, data)
            int rowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            DataGridViewRow placeholderRow = dgvTarefas.Rows[rowIndex];
            placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;

            // Trava as células vazias da linha "Adicionar"
            placeholderRow.Cells["colID"].ReadOnly = true;
            placeholderRow.Cells["colResp"].ReadOnly = true;
            placeholderRow.Cells["colStatus"].ReadOnly = true;
            placeholderRow.Cells["colData"].ReadOnly = true;
        }

        // Evento de clique para o cabeçalho "Este mês"
        private void HeaderEsteMes_Click(object sender, EventArgs e)
        {
            isPainelTarefasVisivel = !isPainelTarefasVisivel;
            panelTarefasGrid.Visible = isPainelTarefasVisivel;
        }

        // Evento de clique para o botão "Visualizações"
        private void btnVisualizacoes_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                contextMenuStripVisualizacoes.Show(btn, 0, btn.Height);
            }
        }

        /// <summary>
        /// ALTERAÇÃO: Atualiza lógica de clique para 6 colunas
        /// </summary>
        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na linha "+ Adicionar tarefa"
            if (e.RowIndex >= 0 && dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
            {
                DataGridViewRow linhaAtual = dgvTarefas.Rows[e.RowIndex];

                // Limpa o texto da célula
                linhaAtual.Cells["colTarefa"].Value = "";
                linhaAtual.DefaultCellStyle.ForeColor = Color.White;

                // Destrava as outras células para edição
                linhaAtual.Cells["colID"].ReadOnly = false;
                linhaAtual.Cells["colResp"].ReadOnly = false;
                linhaAtual.Cells["colStatus"].ReadOnly = false;
                linhaAtual.Cells["colData"].ReadOnly = false;

                // Adiciona um ID temporário
                linhaAtual.Cells["colID"].Value = (dgvTarefas.Rows.Count - 1).ToString();

                // Move o foco para a célula para edição
                dgvTarefas.CurrentCell = linhaAtual.Cells["colTarefa"];
                dgvTarefas.BeginEdit(true);

                // Adiciona uma nova linha "+ Adicionar tarefa" no final
                int newRowIndex = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
                DataGridViewRow placeholderRow = dgvTarefas.Rows[newRowIndex];
                placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;

                // Trava as células da nova linha placeholder
                placeholderRow.Cells["colID"].ReadOnly = true;
                placeholderRow.Cells["colResp"].ReadOnly = true;
                placeholderRow.Cells["colStatus"].ReadOnly = true;
                placeholderRow.Cells["colData"].ReadOnly = true;
            }
        }

        // Eventos de clique para os itens do menu de visualização (exemplo)
        private void tabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização: Tabela selecionada.");
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização: Gráfico selecionado.");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização: Calendário selecionado.");
        }

        private void kanbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização: Kanban selecionado.");
        }

        private void btnCriarElemento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão 'Criar Elemento' clicado.");
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão 'Adicionar novo grupo' clicado.");
        }

        // ==========================================================
        // VVV SEÇÃO DE CÓDIGO TOTALMENTE NOVA PARA O FILTRO VVV
        // ==========================================================

        /// <summary>
        /// Cria o menu de contexto (botão direito) para o filtro de status.
        /// </summary>
        private void CriarMenuDeFiltro()
        {
            contextMenuFiltroStatus = new ContextMenuStrip();

            // Adiciona as opções de filtro
            var opcoes = new[] { "Mostrar Todos", "Parado", "Concluído", "Em Andamento", "Novo" };

            foreach (string opcao in opcoes)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(opcao);
                // Adiciona o mesmo evento de clique para todos os itens
                item.Click += FiltroStatus_Click;
                contextMenuFiltroStatus.Items.Add(item);
            }
        }

        /// <summary>
        /// Evento de clique do botão "Filtro".
        /// </summary>
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Mostra o menu de filtro logo abaixo do botão
                contextMenuFiltroStatus.Show(btn, 0, btn.Height);
            }
        }

        /// <summary>
        /// Evento de clique para CADA item do menu de filtro.
        /// </summary>
        private void FiltroStatus_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemClicado = sender as ToolStripMenuItem;
            if (itemClicado != null)
            {
                string statusFiltro = itemClicado.Text;

                if (statusFiltro == "Mostrar Todos")
                {
                    AplicarFiltroStatus("Todos");
                }
                else
                {
                    AplicarFiltroStatus(statusFiltro);
                }
            }
        }

        /// <summary>
        /// Lógica principal que esconde/mostra as linhas do DataGridView.
        /// </summary>
        private void AplicarFiltroStatus(string statusFiltro)
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

                // 2. Verifica se o filtro é "Mostrar Todos"
                if (statusFiltro == "Todos")
                {
                    row.Visible = true;
                }
                else
                {
                    // 3. Aplica o filtro
                    var statusDaLinha = row.Cells["colStatus"].Value;

                    // Compara o status da linha com o filtro selecionado
                    if (statusDaLinha != null && statusDaLinha.ToString().Equals(statusFiltro, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        // <<< O MÉTODO 'panelToolbar_Paint' AGORA SÓ EXISTE AQUI >>>
        private void panelToolbar_Paint(object sender, PaintEventArgs e)
        {
            // Este método é referenciado pelo Designer.
            // Pode deixar em branco se não precisar de nenhuma lógica de pintura.
        }
    }
}