using structa_front.Forms;
using structa_front.Models;
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

namespace structa_front
{
    public partial class FormPrincipal : BaseForm
    {
        private string textoPagina;
        private List<Projeto> cachedProjetos = new List<Projeto>();

        // >>> VARIÁVEIS PARA RESTAURAR O panelTop <<<
        private Control[] panelTopOriginalControls;
        private Size panelTopOriginalSize;
        private Point panelConteudoOriginalLocation;

        public FormPrincipal(string pagina)
        {
            InitializeComponent();

            // >>> SALVA ESTADO ORIGINAL DO panelTop <<<
            panelTopOriginalControls = panelTop.Controls.Cast<Control>().ToArray();
            panelTopOriginalSize = panelTop.Size;
            panelConteudoOriginalLocation = panelConteudo.Location;

            AbrirPagina(new UcPaginaInicial());
            textoPagina = pagina;
            lblPagina.Text = textoPagina;
            lblPaginaMin.Text = textoPagina;

            ProjectEvents.ProjectsUpdated += async () => await PreloadProjetosAsync();
            _ = PreloadProjetosAsync();
        }

        // >>> MÉTODO PARA RESTAURAR panelTop <<<
        private void RestaurarPanelTop()
        {
            panelTop.Size = panelTopOriginalSize;
            panelConteudo.Location = panelConteudoOriginalLocation;

            panelTop.Controls.Clear();
            foreach (var ctrl in panelTopOriginalControls)
                panelTop.Controls.Add(ctrl);
        }

        public void AbrirPagina(UserControl pagina)
        {
            panelConteudo.Controls.Clear();

            pagina.Size = new Size(panelConteudo.Width, 800);
            pagina.Location = new Point(0, 0);

            panelConteudo.Controls.Add(pagina);
            panelConteudo.AutoScroll = true;
        }

        private void SelecionarProjeto(int projetoId, string nome)
        {
            Sessao.ProjetoId = projetoId;

            var ucProjeto = new UcPlanoDeGestao(projetoId, nome);
            AbrirPagina(ucProjeto);

            lblPagina.Text = nome;
            lblPaginaMin.Text = nome;

            flpProjetos.Visible = false;
        }

        private async Task PreloadProjetosAsync()
        {
            try
            {
                var service = new Services.ProjetosService();
                cachedProjetos = await service.BuscarProjetosAsync(Sessao.UsuarioId);
            }
            catch
            {
                cachedProjetos = new List<Projeto>();
            }
        }

        private async Task CarregarProjetosAsync()
        {
            try
            {
                flpProjetos.Controls.Clear();

                var projetos = (cachedProjetos != null && cachedProjetos.Count > 0)
                    ? cachedProjetos
                    : await new Services.ProjetosService().BuscarProjetosAsync(Sessao.UsuarioId);

                foreach (var proj in projetos)
                {
                    var btnProjeto = new Button
                    {
                        Text = proj.Nome,
                        Width = flpProjetos.Width - 10,
                        Height = 35,
                        BackColor = Color.FromArgb(60, 60, 60),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Tag = proj.Id
                    };

                    btnProjeto.FlatAppearance.BorderSize = 0;

                    btnProjeto.Click += (s, e) =>
                    {
                        SelecionarProjeto(proj.Id, proj.Nome);
                    };

                    flpProjetos.Controls.Add(btnProjeto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);
            }
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            Painel_Perfil painel = new Painel_Perfil(this);

            panelTop.Size = new Size(1190, 212);
            panelConteudo.Location = new Point(327, 212);

            panelTop.Controls.Clear();
            panelTop.Controls.Add(painel);

            lblPagina.Text = "Perfil";
            lblPaginaMin.Text = "Perfil";

            AbrirPagina(new panel());
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            Notificacoes notificacoes = new Notificacoes();
            notificacoes.Show();
        }

        // >>> RESTAURAÇÃO AO CLICAR EM ÁREA DE TRABALHO <<<
        private void btnAreaDeTrabalho_Click(object sender, EventArgs e)
        {
            RestaurarPanelTop();

            AbrirPagina(new UcPaginaInicial());
            lblPagina.Text = "Áreas de trabalho";
            lblPaginaMin.Text = "Áreas de trabalho";
        }

        private void btnAdicionarMembros_Click(object sender, EventArgs e)
        {
            AdicionarMembros convidarMembros = new AdicionarMembros();
            convidarMembros.Show();
        }

        // >>> RESTAURAÇÃO AO CLICAR EM "Página Inicial" <<<
        private void label1_Click(object sender, EventArgs e)
        {
            RestaurarPanelTop();

            AbrirPagina(new UcPaginaInicial());
            lblPagina.Text = "Página Inicial";
            lblPaginaMin.Text = "Página Inicial";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            RestaurarPanelTop();

            AbrirPagina(new UcPlanoDeGestao());
            lblPagina.Text = "Plano de gestão";
            lblPaginaMin.Text = "Plano de gestão";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form NovoProjeto = new Forms.NovoProjeto();
            NovoProjeto.Show();
        }

        // >>> RESTAURAÇÃO AO CLICAR EM "Área de Trabalho" (label) <<<
        private void label5_Click(object sender, EventArgs e)
        {
            RestaurarPanelTop();

            AbrirPagina(new UcAreaDeTrabalho());
            lblPagina.Text = "Área de trabalho";
            lblPaginaMin.Text = "Área de trabalho";
        }

        // >>> RESTAURAÇÃO AO CLICAR NO ÍCONE DA ÁREA DE TRABALHO <<<
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            RestaurarPanelTop();

            AbrirPagina(new UcAreaDeTrabalho());
            lblPagina.Text = "Área de trabalho";
            lblPaginaMin.Text = "Área de trabalho";
        }

        private async void btnSeta_Click_1(object sender, EventArgs e)
        {
            flpProjetos.Visible = !flpProjetos.Visible;

            if (flpProjetos.Visible)
            {
                await CarregarProjetosAsync();
            }
        }
    }
}
