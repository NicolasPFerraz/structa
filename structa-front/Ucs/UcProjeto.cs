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

        // LISTA DE RESPONSÁVEIS DO PROJETO (NOVO)
        // Use BindingList para suportar binding/atualização mais segura
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

                listaResponsaveis.Clear();

                foreach (var u in lista)
                {
                    listaResponsaveis.Add(u.Item2.Nome);
                }

                if (listaResponsaveis.Count == 0)
                    listaResponsaveis.Add("Sem responsáveis");
            }
            catch
            {
                listaResponsaveis.Clear();
                listaResponsaveis.Add("Erro ao carregar");
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

                    // Preenche automaticamente o combo de responsáveis
                    var comboResp = dgvTarefas.Rows[rowIndex].Cells["colResp"] as DataGridViewComboBoxCell;
                    if (comboResp != null)
                    {
                        var respItems = new List<string>(listaResponsaveis);
                        if (!string.IsNullOrWhiteSpace(tarefa.Responsavel) && !respItems.Contains(tarefa.Responsavel))
                        {
                            // garante que o valor atual aparece na lista do combobox dessa célula
                            respItems.Insert(0, tarefa.Responsavel);
                        }
                        comboResp.DataSource = respItems;
                        // garante que o valor seja selecionado
                        comboResp.Value = tarefa.Responsavel;
                    }

                    // Ajusta o combobox de status para garantir que o valor atual exista
                    var statusCell = dgvTarefas.Rows[rowIndex].Cells["colStatus"] as DataGridViewComboBoxCell;
                    if (statusCell != null)
                    {
                        var statuses = new List<string> { "Parado", "Concluído", "Em Andamento", "Novo" };
                        if (!string.IsNullOrWhiteSpace(tarefa.Status) && !statuses.Contains(tarefa.Status))
                        {
                            statuses.Insert(0, tarefa.Status);
                        }
                        statusCell.DataSource = statuses;
                        statusCell.Value = tarefa.Status;
                    }
                }
            }

            int r = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
            var placeholder = dgvTarefas.Rows[r];
            placeholder.DefaultCellStyle.ForeColor = Color.Gray;

            placeholder.Cells["colID"].ReadOnly = true;
            placeholder.Cells["colResp"].ReadOnly = true;
            placeholder.Cells["colStatus"].ReadOnly = true;
            placeholder.Cells["colData"].ReadOnly = true;

            // garante que placeholder mostre os responsáveis (se houver)
            var placeholderCombo = placeholder.Cells["colResp"] as DataGridViewComboBoxCell;
            if (placeholderCombo != null)
            {
                placeholderCombo.DataSource = new List<string>(listaResponsaveis);
            }

            var placeholderStatus = placeholder.Cells["colStatus"] as DataGridViewComboBoxCell;
            if (placeholderStatus != null)
            {
                placeholderStatus.DataSource = new List<string> { "Parado", "Concluído", "Em Andamento", "Novo" };
            }
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

            // NOVO: TRANSFORMAMOS colResp EM COMBOBOX
            var respColumn = new DataGridViewComboBoxColumn
            {
                Name = "colResp",
                HeaderText = "Resp.",
                Width = 140,
                FlatStyle = FlatStyle.Flat,
                DataSource = listaResponsaveis
            };
            dgvTarefas.Columns.Add(respColumn);

            var statusColumn = new DataGridViewComboBoxColumn
            { Name = "colStatus", HeaderText = "Status", Width = 120, FlatStyle = FlatStyle.Flat };

            // usa lista fixa de status no nível da coluna
            statusColumn.DataSource = new List<string> { "Parado", "Concluído", "Em Andamento", "Novo" };

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

            // lidar graciosamente com erros de binding (valores que não existem na lista do combobox)
            dgvTarefas.DataError += DgvTarefas_DataError;

            this.dgvTarefas.CellPainting += dgvTarefas_CellPainting;

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

        private void DgvTarefas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignora erros de binding quando o valor atual não está presente na lista do ComboBox.
            e.ThrowException = false;
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

        private async void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTarefas.Rows[e.RowIndex];

            var titulo = Convert.ToString(row.Cells["colTarefa"].Value);
            if (string.IsNullOrWhiteSpace(titulo) || titulo == "+ Adicionar tarefa")
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

                        // Garantir que o combobox desta linha esteja configurado e editável
                        var comboResp = row.Cells["colResp"] as DataGridViewComboBoxCell;
                        if (comboResp != null)
                        {
                            var respItems = new List<string>(listaResponsaveis);
                            var cellRespVal = Convert.ToString(row.Cells["colResp"].Value);
                            if (!string.IsNullOrWhiteSpace(cellRespVal) && !respItems.Contains(cellRespVal))
                                respItems.Insert(0, cellRespVal);

                            comboResp.DataSource = respItems;
                            row.Cells["colResp"].ReadOnly = false;

                            if (!string.IsNullOrWhiteSpace(cellRespVal))
                                comboResp.Value = cellRespVal;
                        }

                        var statusCell = row.Cells["colStatus"] as DataGridViewComboBoxCell;
                        if (statusCell != null)
                        {
                            var statuses = new List<string> { "Parado", "Concluído", "Em Andamento", "Novo" };
                            var cellStatusVal = Convert.ToString(row.Cells["colStatus"].Value);
                            if (!string.IsNullOrWhiteSpace(cellStatusVal) && !statuses.Contains(cellStatusVal))
                                statuses.Insert(0, cellStatusVal);

                            statusCell.DataSource = statuses;
                            row.Cells["colStatus"].ReadOnly = false;

                            if (!string.IsNullOrWhiteSpace(cellStatusVal))
                                statusCell.Value = cellStatusVal;
                        }

                        // Se a criação veio da linha placeholder (última linha), adiciona um novo placeholder imediatamente
                        if (e.RowIndex == dgvTarefas.Rows.Count - 1)
                        {
                            int r = dgvTarefas.Rows.Add(false, "", "+ Adicionar tarefa", "", "", "");
                            var placeholder = dgvTarefas.Rows[r];
                            placeholder.DefaultCellStyle.ForeColor = Color.Gray;

                            // Define colunas de somente leitura na nova linha placeholder
                            placeholder.Cells["colID"].ReadOnly = true;
                            placeholder.Cells["colResp"].ReadOnly = true;
                            placeholder.Cells["colStatus"].ReadOnly = true;
                            placeholder.Cells["colData"].ReadOnly = true;

                            // Ajusta o DataSource do combobox de responsáveis na nova linha
                            var placeholderCombo = placeholder.Cells["colResp"] as DataGridViewComboBoxCell;
                            if (placeholderCombo != null)
                            {
                                placeholderCombo.DataSource = new List<string>(listaResponsaveis);
                            }

                            var placeholderStatus = placeholder.Cells["colStatus"] as DataGridViewComboBoxCell;
                            if (placeholderStatus != null)
                            {
                                placeholderStatus.DataSource = new List<string> { "Parado", "Concluído", "Em Andamento", "Novo" };
                            }
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
