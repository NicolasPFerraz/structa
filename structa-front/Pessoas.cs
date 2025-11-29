using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace structa_front
{
    public partial class FrmPessoasCadastradas : Form
    {
        // Variáveis para permitir arrastar o formulário sem bordas
        private bool isDragging = false;
        private Point dragStartPoint = new Point(0, 0);

        // Lista de pessoas (exemplo)
        private List<string> todasAsPessoas = new List<string>
        {
            "Alan", "Amanda", "Anna", "Fernando", "Gregory", "Jessy",
            "Raphael", "Jeronimo", "Elisa", "Bruno", "Carla"
        };

        // Guarda quem está selecionado
        private string pessoaSelecionada = null;

        public FrmPessoasCadastradas()
        {
            InitializeComponent();
        }

        private void FrmPessoasCadastradas_Load(object sender, EventArgs e)
        {
            // --- Eventos ---
            lblClose.Click += (s, ev) => this.Close();
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;

            // Placeholder "Pesquisar"
            AdicionarPlaceholder();

            
            // Carrega a lista de pessoas
            CarregarPessoas();
        }

        /// <summary>
        /// Carrega e exibe a lista de pessoas no FlowLayoutPanel.
        /// </summary>
        private void CarregarPessoas()
        {
            flpPessoas.Controls.Clear();
            foreach (var nome in todasAsPessoas.OrderBy(n => n))
            {
                Panel item = CriarItemPessoa(nome);
                flpPessoas.Controls.Add(item);
            }
        }

        /// <summary>
        /// Cria o control visual (Icone + Nome) para uma pessoa.
        /// </summary>
        private Panel CriarItemPessoa(string nome)
        {
            Panel panel = new Panel
            {
                Width = flpPessoas.ClientSize.Width - 5, // Largura do FlowPanel
                Height = 30,
                Margin = new Padding(0, 5, 0, 5),
                Cursor = Cursors.Hand,
                Tag = nome // Guarda o nome aqui para referência
            };

            Label lblIcon = new Label
            {
                Text = "👤", // Emoji de pessoa (requer fonte Segoe UI Emoji)
                Font = new Font("Segoe UI Emoji", 10F),
                ForeColor = Color.White,
                Location = new Point(5, 5),
                Size = new Size(20, 20)
            };

            Label lblNome = new Label
            {
                Text = nome,
                Font = new Font("Segoe UI", 9.75F),
                ForeColor = Color.White,
                Location = new Point(30, 6),
                AutoSize = true
            };

            // Encaminha o clique de todos os controlos para o evento principal
            panel.Click += ItemPessoa_Click;
            lblIcon.Click += (s, e) => ItemPessoa_Click(panel, e);
            lblNome.Click += (s, e) => ItemPessoa_Click(panel, e);

            panel.Controls.Add(lblIcon);
            panel.Controls.Add(lblNome);
            return panel;
        }

        /// <summary>
        /// Chamado quando o utilizador clica num nome.
        /// </summary>
        private void ItemPessoa_Click(object sender, EventArgs e)
        {
            Panel panel = (sender is Panel p) ? p : (sender as Control)?.Parent as Panel;
            if (panel == null) return;

            pessoaSelecionada = panel.Tag.ToString();

            // (Opcional) Mostra quem foi selecionado e fecha
            MessageBox.Show($"Você selecionou: {pessoaSelecionada}");
            this.Close(); // Fecha o pop-up após a seleção
        }

        /// <summary>
        /// Filtra a lista de pessoas visíveis com base no texto da pesquisa.
        /// </summary>
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.ToLower();
            if (termo == "pesquisar") termo = ""; // Ignora o placeholder

            foreach (Control item in flpPessoas.Controls)
            {
                if (item is Panel)
                {
                    string nome = item.Tag.ToString().ToLower();
                    item.Visible = nome.Contains(termo);
                }
            }
        }

        #region Lógica do Placeholder e Arrastar

        private void AdicionarPlaceholder()
        {
            txtPesquisar.Text = "Pesquisar";
            txtPesquisar.ForeColor = Color.Gray;

            txtPesquisar.GotFocus += (s, e) => {
                if (txtPesquisar.Text == "Pesquisar")
                {
                    txtPesquisar.Text = "";
                    txtPesquisar.ForeColor = Color.White;
                }
            };
            txtPesquisar.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPesquisar.Text))
                {
                    txtPesquisar.Text = "Pesquisar";
                    txtPesquisar.ForeColor = Color.Gray;
                }
            };
        }

        private void SetupDragEvents(Control control)
        {
            control.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    dragStartPoint = new Point(e.X, e.Y);
                }
            };
            control.MouseUp += (s, e) => {
                isDragging = false;
            };
            control.MouseMove += (s, e) => {
                if (isDragging)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - dragStartPoint.X, p.Y - dragStartPoint.Y);
                }
            };
        }

        #endregion
    }
}