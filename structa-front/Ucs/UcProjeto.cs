using structa_front.Models;
using structa_front;
using structa_front.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace structa_front
{
    public partial class UcPlanoDeGestao : UserControl
    {
        private int projetoIdSelecionado = 0;
        private string projetoNomeSelecionado = string.Empty;
        private bool isPainelTarefasVisivel = true;

        private ContextMenuStrip contextMenuFiltroStatus;

        private bool isSortAscending = true;
        private bool areCompletedTasksHidden = false;
        private string filtroStatusAtual = "Todos";

        // Use BindingList so changes propagate to DataGridViewComboBoxColumn
        private BindingList<string> listaResponsaveis = new BindingList<string>();

        public UcPlanoDeGestao()
        {
            InitializeComponent();
        }

        public UcPlanoDeGestao(int projetoId, string nome) : this()
        {
            projetoIdSelecionado = projetoId;
            projetoNomeSelecionado = nome;

            try
            {
                if (lblTitulo != null && !string.IsNullOrWhiteSpace(projetoNomeSelecionado))
                {
                    lblTitulo.Text = projetoNomeSelecionado;
                }
            }
            catch { }
        }

        private async Task CarregarResponsaveisDoProjeto()
        {
            try
            {
                var membrosProjetoService = new MembrosProjetoService();

                // BUSCA TODAS AS PESSOAS DO PROJETO
                var lista = await membrosProjetoService.BuscarMembrosComDadosAsync(projetoIdSelecionado);

                // Update the binding list rather than replacing it
                listaResponsaveis.Clear();

                foreach (var u in lista)
                {
                    if (!string.IsNullOrWhiteSpace(u.Item2?.Nome))
                        listaResponsaveis.Add(u.Item2.Nome);
                }

                if (listaResponsaveis.Count == 0)
                    listaResponsaveis.Add("Sem responsáveis");

                // If grid already has combo column/cells, update their DataSource
                AtualizarFonteComboResponsaveis();
            }
            catch
            {
                listaResponsaveis.Clear();
                listaResponsaveis.Add("Erro ao carregar");
                AtualizarFonteComboResponsaveis();
            }
        }

        private void AtualizarFonteComboResponsaveis()
        {
            if (dgvTarefas == null) return;

            if (dgvTarefas.Columns.Contains("colResp"))
            {
                var col = dgvTarefas.Columns["colResp"] as DataGridViewComboBoxColumn;
                if (col != null)
                {
                    col.DataSource = listaResponsaveis;
                    col.ValueType = typeof(string);
                }

                // Também defina cada célula existente para usar a lista de vinculação para que o controle de edição veja os itens
                foreach (DataGridViewRow row in dgvTarefas.Rows)
                {
                    if (row.IsNewRow) continue;
                    var cell = row.Cells["colResp"] as DataGridViewComboBoxCell;
                    if (cell != null)
                    {
                        cell.DataSource = listaResponsaveis;
                    }
                }
            }
        }

        private async void retornarTarefas()
        {
            var TarefasService = new Services.TarefasService();
            dgvTarefas.Rows.Clear();

            try
            {
                var listaTarefas = await TarefasService.ObterTarefasAsync(Sessao.UsuarioId, projetoIdSelecionado);

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

        private void PreencherGridComTarefas(List<Tarefa> listaTarefas)
        {
            // Remove placeholder(s) antes de preencher
            for (int i = dgvTarefas.Rows.Count - 1; i >= 0; i--)
            {
                var val = dgvTarefas.Rows[i].Cells["colTarefa"].Value;
                if (val != null && val.ToString() == "+ Adicionar tarefa")
                {
                    dgvTarefas.Rows.RemoveAt(i);
                }
            }

            if (listaTarefas != null)
            {
                foreach (var tarefa in listaTarefas)
                {
                    var rowIndex = dgvTarefas.Rows.Add(false, tarefa.Id, tarefa.Titulo, tarefa.Responsavel, tarefa.Status, tarefa.PrazoFinalEntrega);

                    // Ensure the combo cell uses the binding list
                    var comboResp = dgvTarefas.Rows[rowIndex].Cells["colResp"] as DataGridViewComboBoxCell;
                    if (comboResp != null)
                        comboResp.DataSource = listaResponsaveis;
                }
            }

            // Sempre garanta um placeholder no final
            int r = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            var placeholder = dgvTarefas.Rows[r];
            placeholder.DefaultCellStyle.ForeColor = Color.Gray;

            placeholder.Cells["colID"].ReadOnly = true;
            placeholder.Cells["colResp"].ReadOnly = true;
            placeholder.Cells["colStatus"].ReadOnly = true;
            placeholder.Cells["colData"].ReadOnly = true;

            // Ensure combo column/cells know about the current data
            AtualizarFonteComboResponsaveis();
        }

        private void ConfigurarColunasDataGridView()
        {
            dgvTarefas.Columns.Clear();

            dgvTarefas.Columns.Add(new DataGridViewCheckBoxColumn
            { Name = "colCheck", HeaderText = "", Width = 30 });

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colID", HeaderText = "ID", Width = 50 });

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colTarefa", HeaderText = "Tarefa", Width = 300 });

            // NOVO: TRANSFORMAMOS colResp EM COMBOBOX (bind to BindingList)
            var respColumn = new DataGridViewComboBoxColumn
            {
                Name = "colResp",
                HeaderText = "Resp.",
                Width = 140,
                FlatStyle = FlatStyle.Flat,
                DataSource = listaResponsaveis,
                ValueType = typeof(string)
            };
            dgvTarefas.Columns.Add(respColumn);

            var statusColumn = new DataGridViewComboBoxColumn
            { Name = "colStatus", HeaderText = "Status", Width = 120, FlatStyle = FlatStyle.Flat };

            statusColumn.Items.Add("Parado");
            statusColumn.Items.Add("Concluído");
            statusColumn.Items.Add("Em Andamento");
            statusColumn.Items.Add("Novo");

            dgvTarefas.Columns.Add(statusColumn);

            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colData", HeaderText = "Data", Width = 100 });

            dgvTarefas.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colExcluir",
                HeaderText = "",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            // Improve edit behavior so combobox opens on click
            dgvTarefas.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void CarregarDadosDeExemplo()
        {
            int r = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            var placeholder = dgvTarefas.Rows[r];
            placeholder.DefaultCellStyle.ForeColor = Color.Gray;

            placeholder.Cells["colID"].ReadOnly = true;
            placeholder.Cells["colResp"].ReadOnly = true;
            placeholder.Cells["colStatus"].ReadOnly = true;
            placeholder.Cells["colData"].ReadOnly = true;
        }

        private void HeaderEsteMes_Click(object sender, EventArgs e)
        {
            isPainelTarefasVisivel = !isPainelTarefasVisivel;
            panelTarefasGrid.Visible = isPainelTarefasVisivel;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            isSortAscending = !isSortAscending;
            AplicarOrdenacao();
        }

        private void AplicarOrdenacao()
        {
            var direction = isSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            dgvTarefas.Sort(dgvTarefas.Columns["colTarefa"], direction);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            areCompletedTasksHidden = !areCompletedTasksHidden;

            btnOcultar.Text = areCompletedTasksHidden ? "Mostrar Concluídas" : "Ocultar Concluídas";
            AtualizarVisibilidadeLinhas();
        }

        private void CriarMenuDeFiltro()
        {
            contextMenuFiltroStatus = new ContextMenuStrip();
            var opcoes = new[] { "Mostrar Todos", "Parado", "Concluído", "Em Andamento", "Novo" };

            foreach (string opcao in opcoes)
            {
                var item = new ToolStripMenuItem(opcao);
                item.Click += FiltroStatus_Click;
                contextMenuFiltroStatus.Items.Add(item);
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            contextMenuFiltroStatus?.Show(btnFiltro, 0, btnFiltro.Height);
        }

        private void FiltroStatus_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            filtroStatusAtual = (item.Text == "Mostrar Todos") ? "Todos" : item.Text;
            AtualizarVisibilidadeLinhas();
        }

        private void AtualizarVisibilidadeLinhas()
        {
            foreach (DataGridViewRow row in dgvTarefas.Rows)
            {
                var titulo = Convert.ToString(row.Cells["colTarefa"].Value);
                if (titulo == "+ Adicionar tarefa")
                {
                    row.Visible = true;
                    continue;
                }

                bool isVisible = true;
                var status = Convert.ToString(row.Cells["colStatus"].Value);

                if (filtroStatusAtual != "Todos" &&
                    !status.Equals(filtroStatusAtual, StringComparison.OrdinalIgnoreCase))
                {
                    isVisible = false;
                }

                if (isVisible && areCompletedTasksHidden && status == "Concluído")
                {
                    isVisible = false;
                }

                row.Visible = isVisible;
            }
        }

        private async void UcPlanoDeGestao_Load(object sender, EventArgs e)
        {
            // 1. Carregar lista de responsáveis do projeto
            await CarregarResponsaveisDoProjeto();

            // 2. Criar colunas já com o ComboBox populado
            ConfigurarColunasDataGridView();

            this.dgvTarefas.CellPainting += dgvTarefas_CellPainting;
            this.dgvTarefas.CellClick += dgvTarefas_CellClick;
            this.dgvTarefas.EditingControlShowing += dgvTarefas_EditingControlShowing;

            CarregarDadosDeExemplo();
            CriarMenuDeFiltro();

            if (projetoIdSelecionado == 0 && Sessao.ProjetoId != 0)
            {
                projetoIdSelecionado = Sessao.ProjetoId;
            }

            // 3. Carregar tarefas
            retornarTarefas();

            this.btnFiltro.Click += btnFiltro_Click;
            this.btnOrdenar.Click += btnOrdenar_Click;
            this.btnOcultar.Click += btnOcultar_Click;
        }

        private void dgvTarefas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvTarefas.Columns[e.ColumnIndex].Name != "colExcluir") return;

            var titulo = Convert.ToString(dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].Value);

            if (titulo == "+ Adicionar tarefa")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Handled = true;
                return;
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            e.Handled = true;
        }

        private void dgvTarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvTarefas.Rows[e.RowIndex];
                var tituloCell = row.Cells["colTarefa"];
                if (tituloCell?.Value != null && tituloCell.Value.ToString() == "+ Adicionar tarefa")
                {
                    // Prepare row for editing: clear placeholder text and start edit on Tarefa cell
                    tituloCell.Value = string.Empty;
                    row.DefaultCellStyle.ForeColor = Color.White;

                    int colIndex = dgvTarefas.Columns["colTarefa"].Index;
                    dgvTarefas.CurrentCell = row.Cells[colIndex];
                    dgvTarefas.BeginEdit(true);
                    return;
                }

                // If clicked on a combobox column, begin edit and open dropdown
                var colName = dgvTarefas.Columns[e.ColumnIndex].Name;
                if (colName == "colResp" || colName == "colStatus")
                {
                    dgvTarefas.CurrentCell = dgvTarefas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvTarefas.BeginEdit(true);

                    // ensure editing control exists first, then open dropdown
                    this.BeginInvoke(new Action(() =>
                    {
                        var editingControl = dgvTarefas.EditingControl as ComboBox;
                        if (editingControl != null)
                        {
                            try { editingControl.DroppedDown = true; } catch { }
                        }
                    }));
                }
            }
            catch
            {
                // ignore
            }
        }

        private void dgvTarefas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTarefas.CurrentCell == null) return;

            var colName = dgvTarefas.CurrentCell.OwningColumn.Name;
            if ((colName == "colResp" || colName == "colStatus") && e.Control is ComboBox cb)
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;

                // open dropdown reliably after control is ready
                BeginInvoke(new Action(() =>
                {
                    try { cb.DroppedDown = true; } catch { }
                }));
            }
        }

        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTarefas.Rows[e.RowIndex];

            var tituloObj = row.Cells["colTarefa"].Value;
            var titulo = Convert.ToString(tituloObj);

            // If user left the cell empty, restore placeholder for rows without ID
            if (string.IsNullOrWhiteSpace(titulo))
            {
                var idVal = Convert.ToString(row.Cells["colID"].Value);
                if (string.IsNullOrWhiteSpace(idVal))
                {
                    row.Cells["colTarefa"].Value = "+ Adicionar tarefa";
                    row.DefaultCellStyle.ForeColor = Color.Gray;

                    row.Cells["colID"].ReadOnly = true;
                    row.Cells["colResp"].ReadOnly = true;
                    row.Cells["colStatus"].ReadOnly = true;
                    row.Cells["colData"].ReadOnly = true;
                }
                return;
            }

            if (titulo == "+ Adicionar tarefa")
                return;

            int.TryParse(Convert.ToString(row.Cells["colID"].Value), out int existingId);

            var tarefa = new Tarefa
            {
                Id = existingId,
                IdProjeto = projetoIdSelecionado,
                IdUsuario = Sessao.UsuarioId,
                Titulo = titulo,
                Responsavel = Convert.ToString(row.Cells["colResp"].Value),
                Status = Convert.ToString(row.Cells["colStatus"].Value),
                PrazoFinalEntrega = Convert.ToString(row.Cells["colData"].Value),
            };

            var tarefasService = new TarefasService();

            try
            {
                if (tarefa.Id > 0)
                {
                    await tarefasService.AtualizarTarefas(tarefa);
                }
                else
                {
                    var criada = await tarefasService.CriarTarefaAsync(tarefa);
                    if (criada != null)
                    {
                        row.Cells["colID"].Value = criada.Id.ToString();

                        // ensure combo cell is editable and bound
                        var comboResp = row.Cells["colResp"] as DataGridViewComboBoxCell;
                        if (comboResp != null)
                        {
                            comboResp.DataSource = listaResponsaveis;
                            row.Cells["colResp"].ReadOnly = false;
                        }

                        row.Cells["colStatus"].ReadOnly = false;
                        row.Cells["colData"].ReadOnly = false;
                        row.DefaultCellStyle.ForeColor = Color.White;

                        // If this was the placeholder row (last row), add a fresh placeholder at the end
                        if (e.RowIndex == dgvTarefas.Rows.Count - 1)
                        {
                            int r = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
                            var placeholder = dgvTarefas.Rows[r];
                            placeholder.DefaultCellStyle.ForeColor = Color.Gray;

                            placeholder.Cells["colID"].ReadOnly = true;
                            placeholder.Cells["colResp"].ReadOnly = true;
                            placeholder.Cells["colStatus"].ReadOnly = true;
                            placeholder.Cells["colData"].ReadOnly = true;
                        }
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
                var tarefasService = new TarefasService();
                await tarefasService.DeletarTarefaAsync(idTarefa);
                retornarTarefas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir tarefa: " + ex.Message);
            }
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            FrmPessoasCadastradas f = new FrmPessoasCadastradas();
            f.Show();
        }
    }
}
