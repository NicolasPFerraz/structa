using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using structa_front.Services;
using structa_front.Models;

namespace structa_front
{
    public partial class UcAreaDeTrabalho : UserControl
    {
        private FlowLayoutPanel flpProjetos;

        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            PainelConteudo.Controls.Clear();
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Bottom;
            // Adiciona a página ao painel de conteúdo
            PainelConteudo.Controls.Add(pagina);
        }

        public UcAreaDeTrabalho()
        {
            InitializeComponent();

            // Cria painel dinâmico para listar projetos do usuário
            InitializeProjectsFlowPanel();

            // Carrega projetos quando o controle for exibido
            this.Load += async (s, e) => await CarregarProjetosAsync();
        }

        private void InitializeProjectsFlowPanel()
        {
            flpProjetos = new FlowLayoutPanel();
            flpProjetos.Name = "flpProjetos";

            // Position under the separator/panels declared in designer
            int left = 120; // aligns with pictureBox5 in designer
            int top = 520;  // slightly below pictureBox5

            // Compute a sensible width based on PainelConteudo so it stays aligned
            int width = Math.Max(600, PainelConteudo.Width - left - 120); // leave right margin
            int height = 140;

            flpProjetos.Location = new Point(left, top);
            flpProjetos.Size = new Size(width, height);

            flpProjetos.AutoScroll = true;
            flpProjetos.WrapContents = false;
            flpProjetos.FlowDirection = FlowDirection.TopDown;
            flpProjetos.BackColor = Color.Transparent;

            // Anchor to top, left and right so it resizes with the parent content area
            flpProjetos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Update child widths when the panel resizes
            flpProjetos.SizeChanged += (s, e) =>
            {
                foreach (Control c in flpProjetos.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.Width = Math.Max(200, flpProjetos.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10);
                    }
                }
            };

            // Add to the designer panel so z-order and layout remain consistent
            PainelConteudo.Controls.Add(flpProjetos);
            flpProjetos.BringToFront();
        }

        // Public method to load projects for the current session user
        public async Task CarregarProjetosAsync()
        {
            try
            {
                flpProjetos.Controls.Clear();

                var projetosService = new ProjetosService();
                var projetos = await projetosService.BuscarProjetosAsync(Sessao.UsuarioId);

                if (projetos == null || projetos.Count == 0)
                {
                    var lblEmpty = new Label
                    {
                        Text = "Nenhum projeto encontrado",
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Padding = new Padding(6)
                    };
                    flpProjetos.Controls.Add(lblEmpty);
                    return;
                }

                foreach (var proj in projetos)
                {
                    var btnProjeto = new Button
                    {
                        Text = proj.Nome,
                        Width = Math.Max(200, flpProjetos.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10),
                        Height = 40,
                        BackColor = Color.FromArgb(60, 60, 60),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Tag = proj.Id
                    };

                    btnProjeto.FlatAppearance.BorderSize = 0;

                    // Capture local variable for closure
                    int projetoId = proj.Id;
                    string projetoNome = proj.Nome;

                    btnProjeto.Click += (s, e) =>
                    {
                        // Define projeto na sessão
                        Sessao.ProjetoId = projetoId;

                        // Tenta abrir no FormPrincipal (página principal)
                        var parentForm = this.FindForm() as FormPrincipal;
                        if (parentForm != null)
                        {
                            parentForm.AbrirPagina(new UcPlanoDeGestao(projetoId, projetoNome));
                        }
                        else
                        {
                            // Fallback: abre dentro deste controle
                            AbrirPagina(new UcPlanoDeGestao(projetoId, projetoNome));
                        }
                    };

                    flpProjetos.Controls.Add(btnProjeto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ao clicar no título, recarrega a lista de projetos
            _ = CarregarProjetosAsync();
        }

        private void PainelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
