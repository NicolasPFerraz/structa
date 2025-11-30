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

namespace structa_front
{
    public partial class FormPrincipal : BaseForm
    {
        private string textoPagina; // <-- campo para armazenar o valor recebido

        // Construtor que recebe o valor
        public FormPrincipal(string pagina)
        {
            InitializeComponent();
            AbrirPagina(new UcPaginaInicial());
            textoPagina = pagina;
            lblPagina.Text = textoPagina; // Exibe no label
            lblPaginaMin.Text = textoPagina; // Exibe no label
        }

        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            panelConteudo.Controls.Clear();

            // Configura o tamanho do UserControl (maior que o panelConteudo para rolar)
            pagina.Size = new Size(panelConteudo.Width, 800); // ou a altura que precisar
            pagina.Location = new Point(0, 0);

            // Adiciona ao panel
            panelConteudo.Controls.Add(pagina);

            // Ativa rolagem
            panelConteudo.AutoScroll = true;
        }
        private void SelecionarProjeto(int projetoId, string nome)
        {
            MessageBox.Show("Projeto selecionado: " + nome);
            Sessao.ProjetoId = projetoId;

            flpProjetos.Visible = false;
        }

        private async Task CarregarProjetosAsync()
        {
            try
            {
                flpProjetos.Controls.Clear();

                var service = new Services.ProjetosService();
                var projetos = await service.BuscarProjetosAsync(Sessao.UsuarioId);

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

        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            Painel_Perfil painel_Perfil = new Painel_Perfil(this);

            panelTop.Size = new System.Drawing.Size(1190, 212);
            panelConteudo.Location = new System.Drawing.Point(287, 211);
            panelTop.Controls.Clear();
            panelTop.Controls.Add(new Painel_Perfil(this));
            lblPagina.Text = "Perfil"; // Exibe no label
            lblPaginaMin.Text = "Perfil"; // Exibe no label
            AbrirPagina(new panel());

        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            Notificacoes notificacoes = new Notificacoes();
            notificacoes.Show();
        }

        private void btnAreaDeTrabalho_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPaginaInicial());
            lblPagina.Text = "Áreas de trabalho"; // Exibe no label
            lblPaginaMin.Text = "Áreas de trabalho"; // Exibe no label
        }

        private void btnAdicionarMembros_Click(object sender, EventArgs e)
        {
            AdicionarMembros convidarMembros = new AdicionarMembros();
            convidarMembros.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPaginaInicial());
            lblPagina.Text = "Página Inicial"; // Exibe no label
            lblPaginaMin.Text = "Página Inicial"; // Exibe no label

        }

        private void label6_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPlanoDeGestao());
            lblPagina.Text = "Plano de gestão"; // Exibe no label
            lblPaginaMin.Text = "Plano de gestão"; // Exibe no label
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form NovoProjeto = new Forms.NovoProjeto();
            NovoProjeto.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcAreaDeTrabalho());
            lblPagina.Text = "Área de trabalho"; // Exibe no label
            lblPaginaMin.Text = "Área de trabalho"; // Exibe no label
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcAreaDeTrabalho());
            lblPagina.Text = "Área de trabalho"; // Exibe no label
            lblPaginaMin.Text = "Área de trabalho"; // Exibe no label
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPlanoDeGestao());
            lblPagina.Text = "Plano de gestão"; // Exibe no label
            lblPaginaMin.Text = "Plano de gestão"; // Exibe no 
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private async void btnSeta_Click(object sender, EventArgs e)
        {

        }

        private async void btnSeta_Click_1(object sender, EventArgs e)
        {
            // Alternar visibilidade do dropdown
            flpProjetos.Visible = !flpProjetos.Visible;

            if (flpProjetos.Visible)
            {
                await CarregarProjetosAsync();
            }
        }
    }
}
