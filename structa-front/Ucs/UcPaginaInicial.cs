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
            // Ensure flow panel is on top and resizes with parent
            flpProjetos.BringToFront();
            flpProjetos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            flpProjetos.AutoScroll = true;

            // Subscribe to global project updates and preload cached projects
            ProjectEvents.ProjectsUpdated += async () =>
            {
                await PreloadProjetosAsync();
                // Ensure UI update runs on UI thread
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() => _ = CarregarProjetosAsync()));
                }
            };

            // Preload projects in background
            _ = PreloadProjetosAsync();

            // Load projects when the control is shown
            this.Load += async (s, e) => await CarregarProjetosAsync();

            // Carrega dados de exemplo ao inicializar (after layout adjustments)
        }

        // Carrega projetos do banco de dados (método original)
        public async Task CarregarProjetosAsync()
        {
            try
            {
                var projetosService = new ProjetosService();
                // Use cached list if available, otherwise fetch
                var projetos = (cachedProjetos != null && cachedProjetos.Count > 0)
                    ? cachedProjetos
                    : await projetosService.BuscarProjetosAsync(Sessao.UsuarioId);

                flpProjetos.Controls.Clear();

                if (projetos == null || projetos.Count == 0)
                {
                    AddProjetoRow("Nenhum projeto encontrado", new[] { "Comece criando um novo projeto" });
                    return;
                }

                foreach (var projeto in projetos)
                {
                    // Buscar membros do projeto com dados do usuário
                    var membrosService = new MembrosProjetoService();
                    var membrosComDados = await membrosService.BuscarMembrosComDadosAsync(projeto.Id);
                    var nomeMembros = membrosComDados.Select(m => m.Item2.Nome).ToArray();

                    AddProjetoRow(projeto.Nome, nomeMembros, projeto.Id);
                }
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

        // Alternativa original: Carregar apenas usuários do banco
        public async Task CarregarUsuariosAsync()
        {
            try
            {
                var usuariosService = new UsuariosService();
                var usuarios = await usuariosService.BuscarUsuariosAsync();

                flpProjetos.Controls.Clear();

                foreach (var usuario in usuarios)
                {
                    AddProjetoRow(usuario.Nome, new[] { usuario.Email });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");
            }
        }

        // Método para adicionar uma linha com dados específicos
        public void AdicionarProjetoRow(string planoGestao, string[] membros)
        {
            AddProjetoRow(planoGestao, membros);
        }

        // Limpar todos os projetos
        public void LimparProjetos()
        {
            flpProjetos.Controls.Clear();
        }

        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            PainelConteudo.Controls.Clear();
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Bottom;
            // Adiciona a página ao painel de conteúdo
            PainelConteudo.Controls.Add(pagina);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcFeed());
        }

        private void label19_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcAreaDeTrabalho());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void SelecionarProjeto(int projetoId, string nome)
        {
            // Define projeto na sessão
            Sessao.ProjetoId = projetoId;

            // Tenta abrir no FormPrincipal (página principal)
            var parentForm = this.FindForm() as FormPrincipal;
            if (parentForm != null)
            {
                parentForm.AbrirPagina(new UcPlanoDeGestao(projetoId, nome));
            }
            else
            {
                // Fallback: abre dentro deste controle
                AbrirPagina(new UcPlanoDeGestao(projetoId, nome));
            }
        }

        // Adds a single project row to the flow panel
        private void AddProjetoRow(string planoGestao, IEnumerable<string> membros, int? projetoId = null)
        {
            // Calculate a safe width: if flpProjetos not yet measured, use a reasonable fallback
            int safeWidth = flpProjetos.ClientSize.Width;
            if (safeWidth <= 0)
            {
                safeWidth = flpProjetos.Width;
            }
            if (safeWidth <= 0)
            {
                safeWidth = 1000; // fallback
            }

            var row = new Panel
            {
                Width = Math.Max(600, safeWidth - SystemInformation.VerticalScrollBarWidth),
                Height = 48,
                BackColor = Color.FromArgb(15, 30, 50), // subtle background so we can see rows
                Margin = new Padding(0, 0, 0, 6),
                Cursor = projetoId.HasValue ? Cursors.Hand : Cursors.Default
            };

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

            // If this row represents a real project, attach click handler to open it
            if (projetoId.HasValue)
            {
                void OpenProjectHandler(object s, EventArgs e)
                {
                    SelecionarProjeto(projetoId.Value, planoGestao);
                }

                row.Click += OpenProjectHandler;
                lblPlano.Click += OpenProjectHandler;
                lblMembros.Click += OpenProjectHandler;
            }

            row.Controls.Add(lblPlano);
            row.Controls.Add(lblMembros);

            flpProjetos.Controls.Add(row);
        }

        private void flpProjetos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
