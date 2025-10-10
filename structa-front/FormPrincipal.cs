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

        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            Painel_Perfil painel_Perfil = new Painel_Perfil(this);

            panelTop.Size = new System.Drawing.Size(1190, 212);
            panelConteudo.Location = new System.Drawing.Point(247, 211);
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
            NovaAreaDeTrabalho novaArea = new NovaAreaDeTrabalho();
            novaArea.Show();
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
    }
}
