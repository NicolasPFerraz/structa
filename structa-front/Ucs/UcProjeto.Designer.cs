using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace structa_front
{
    public partial class UcPlanoDeGestao : UserControl
    {
        // Flag para controlar o estado de visibilidade do painel de tarefas
        private bool isPainelTarefasVisivel = true;

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

            // Configura o ContextMenuStrip para o botão de visualizações
            // (Isso é feito no Designer, mas podemos garantir aqui)
            // btnVisualizacoes.ContextMenuStrip = contextMenuStripVisualizacoes;
        }

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

            // Coluna Tarefa (Texto)
            DataGridViewTextBoxColumn tarefaColumn = new DataGridViewTextBoxColumn
            {
                Name = "colTarefa",
                HeaderText = "Tarefa",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill // Ocupa o espaço restante
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
            // Adiciona as opções ao ComboBox
            statusColumn.Items.Add("Parado");
            statusColumn.Items.Add("Concluído");
            statusColumn.Items.Add("Em Andamento");
            statusColumn.Items.Add("Novo");
            dgvTarefas.Columns.Add(statusColumn);

            // Coluna Data (Texto - para simplicidade, poderia ser um DatePicker)
            DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn
            {
                Name = "colData",
                HeaderText = "Data",
                Width = 100
            };
            dgvTarefas.Columns.Add(dataColumn);
        }

        private void CarregarDadosDeExemplo()
        {
            // Adiciona linhas de exemplo
            dgvTarefas.Rows.Add(false, "[Exemplo] Reunião Mensal", "Ana", "Parado", "25/11");
            dgvTarefas.Rows.Add(true, "[Exemplo] Relatório Semanal", "Bruno", "Concluído", "24/11");
            dgvTarefas.Rows.Add(false, "[Exemplo] Teste de UI", "Carla", "Em Andamento", "26/11");

            // Linha para "Adicionar tarefa"
            // Adicionamos uma linha especial com texto placeholder
            int rowIndex = dgvTarefas.Rows.Add(false, "+ Adicionar tarefa");
            DataGridViewRow placeholderRow = dgvTarefas.Rows[rowIndex];
            placeholderRow.DefaultCellStyle.ForeColor = Color.Gray;
            placeholderRow.ReadOnly = true; // Impede edição direta, vamos tratar no clique
        }

        // Evento de clique para o cabeçalho "Este mês" (Label ou PictureBox)
        private void HeaderEsteMes_Click(object sender, EventArgs e)
        {
            // Inverte a visibilidade do painel de tarefas
            isPainelTarefasVisivel = !isPainelTarefasVisivel;
            panelTarefasGrid.Visible = isPainelTarefasVisivel;

            // (Opcional) Mudar o ícone da seta (ex: de seta para baixo para seta para direita)
            // picToggleEsteMes.Image = isPainelTarefasVisivel ? Properties.Resources.seta_baixo : Properties.Resources.seta_direita;
        }

        // Evento de clique para o botão "Visualizações"
        private void btnVisualizacoes_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Mostra o ContextMenuStrip logo abaixo do botão
                contextMenuStripVisualizacoes.Show(btn, 0, btn.Height);
            }
        }

        // Trata o clique na célula do DataGridView (para adicionar nova tarefa)
        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na linha "+ Adicionar tarefa" e na coluna "Tarefa"
            if (e.RowIndex >= 0 && dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value.ToString() == "+ Adicionar tarefa")
            {
                // Limpa o texto da célula
                dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value = "";
                dgvTarefas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                dgvTarefas.Rows[e.RowIndex].ReadOnly = false;

                // Move o foco para a célula para edição
                dgvTarefas.CurrentCell = dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"];
                dgvTarefas.BeginEdit(true);

                // Adiciona uma nova linha "+ Adicionar tarefa" no final
                int newRowIndex = dgvTarefas.Rows.Add(false, "+ Adicionar tarefa");
                dgvTarefas.Rows[newRowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                dgvTarefas.Rows[newRowIndex].ReadOnly = true;
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
            // Lógica para criar um novo elemento
            MessageBox.Show("Botão 'Criar Elemento' clicado.");
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo grupo
            MessageBox.Show("Botão 'Adicionar novo grupo' clicado.");
        }
    }
}