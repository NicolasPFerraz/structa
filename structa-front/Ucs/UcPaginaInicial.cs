using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using structa_front.Services;
using structa_front.Models;

namespace structa_front
{
    public partial class UcPaginaInicial : UserControl
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;
        private List<Projeto> cachedProjetos = new List<Projeto>();

        public UcPaginaInicial()
        {
            InitializeComponent();

            AplicarDoubleBuffer();

            flpProjetos.BringToFront();
            flpProjetos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            flpProjetos.AutoScroll = true;

            ProjectEvents.ProjectsUpdated += async () =>
            {
                await PreloadProjetosAsync();
                if (IsHandleCreated)
                {
                    BeginInvoke(new Action(async () => await CarregarProjetosAsync()));
                }
            };

            _ = PreloadProjetosAsync();

            this.Load += async (s, e) => await CarregarProjetosAsync();
            CarregarNomeUsuario();
        }

        private void AplicarDoubleBuffer()
        {
            this.DoubleBuffered = true;
            flpProjetos.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(flpProjetos, true, null);
        }
        private async Task CarregarNomeUsuario()
        {
            if (Sessao.UsuarioId != null)
            {
                var usuarioService = new UsuariosService();
                var result = await usuarioService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                lblNome.Text = $"Olá, {result.Nome}!";
            }
        }

        public async Task CarregarProjetosAsync()
        {
            try
            {
                var projetosService = new ProjetosService();
                var membrosService = new MembrosProjetoService();

                List<Projeto> projetos =
                    (cachedProjetos != null && cachedProjetos.Count > 0)
                    ? cachedProjetos
                    : await projetosService.BuscarProjetosAsync(Sessao.UsuarioId);

                flpProjetos.SuspendLayout();
                flpProjetos.Controls.Clear();

                var controles = new List<Control>();

                if (projetos == null || projetos.Count == 0)
                {
                    controles.Add(
                        CriarProjetoRow(
                            "Nenhum projeto encontrado",
                            new[] { "Comece criando um novo projeto" },
                            null
                        )
                    );

                    flpProjetos.Controls.AddRange(controles.ToArray());
                    flpProjetos.ResumeLayout();
                    return;
                }

                var tarefas = projetos.Select(async proj =>
                {
                    var membros = await membrosService.BuscarMembrosComDadosAsync(proj.Id);
                    string[] nomes = membros.Select(m => m.Item2.Nome).ToArray();

                    return CriarProjetoRow(proj.Nome, nomes, proj.Id);
                });

                var rows = await Task.WhenAll(tarefas);

                controles.AddRange(rows);

                flpProjetos.Controls.AddRange(controles.ToArray());
                flpProjetos.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar projetos: {ex.Message}");
            }
        }

        private async Task PreloadProjetosAsync()
        {
            try
            {
                var service = new ProjetosService();
                cachedProjetos = await service.BuscarProjetosAsync(Sessao.UsuarioId);
            }
            catch
            {
                cachedProjetos = new List<Projeto>();
            }
        }

        public void LimparProjetos()
        {
            flpProjetos.Controls.Clear();
        }

        public void AbrirPagina(UserControl pagina)
        {
            PainelConteudo.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            PainelConteudo.Controls.Add(pagina);
        }

        private void SelecionarProjeto(int projetoId, string nome)
        {
            Sessao.ProjetoId = projetoId;

            var parentForm = this.FindForm() as FormPrincipal;

            if (parentForm != null)
                parentForm.AbrirPagina(new UcPlanoDeGestao(projetoId, nome));
            else
                AbrirPagina(new UcPlanoDeGestao(projetoId, nome));
        }

        private Control CriarProjetoRow(string planoGestao, IEnumerable<string> membros, int? projetoId)
        {
            int width = flpProjetos.ClientSize.Width;
            if (width <= 0) width = 1000;

            var row = new Panel
            {
                Width = width - SystemInformation.VerticalScrollBarWidth,
                Height = 48,
                BackColor = Color.FromArgb(15, 30, 50),
                Margin = new Padding(0, 0, 0, 6),
                Cursor = projetoId.HasValue ? Cursors.Hand : Cursors.Default
            };

            row.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(row, true, null);

            int leftWidth = (int)(row.Width * 0.45);
            int rightWidth = row.Width - leftWidth - 12;

            var lblPlano = new Label
            {
                Location = new Point(6, 8),
                Size = new Size(leftWidth, 32),
                ForeColor = Color.White,
                Text = planoGestao,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            var lblMembros = new Label
            {
                Location = new Point(6 + leftWidth + 6, 8),
                Size = new Size(rightWidth, 32),
                ForeColor = Color.Gray,
                Text = string.Join(", ", membros),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            if (projetoId.HasValue)
            {
                void Open(object s, EventArgs e)
                {
                    SelecionarProjeto(projetoId.Value, planoGestao);
                }

                row.Click += Open;
                lblPlano.Click += Open;
                lblMembros.Click += Open;
            }

            row.Controls.Add(lblPlano);
            row.Controls.Add(lblMembros);

            return row;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcFeed());
        }

        private void label19_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcAreaDeTrabalho());
        }

        private void flpProjetos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
