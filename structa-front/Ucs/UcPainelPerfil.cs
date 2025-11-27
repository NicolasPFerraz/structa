using System;
using System.Windows.Forms;

namespace structa_front
{
    public partial class Painel_Perfil : UserControl
    {
        // Evento que será disparado quando uma página precisa ser aberta

        public Painel_Perfil(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        // No seu UserControl atual
        private FormPrincipal _formPrincipal;

        // Eventos de clique dos botões
        private void PG_Pessoal_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new panel());
            PG_Pessoal.BorderStyle = BorderStyle.FixedSingle;
            PG_StatusTrabalho.BorderStyle = BorderStyle.None;
            PG_Senha.BorderStyle = BorderStyle.None;
            PG_Notificacao.BorderStyle = BorderStyle.None;
        }

        private void PG_StatusTrabalho_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new StatusTrabalho());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.FixedSingle;
            PG_Senha.BorderStyle = BorderStyle.None;
            PG_Notificacao.BorderStyle = BorderStyle.None;

        }

        private void PG_Notificacao_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new Notificacao());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.None;
            PG_Senha.BorderStyle = BorderStyle.None;
            PG_Notificacao.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PG_Senha_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new Senha());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.None;
            PG_Senha.BorderStyle = BorderStyle.FixedSingle;
            PG_Notificacao.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementar ação
        }

        private void Painel_Perfil_Load(object sender, EventArgs e)
        {
            // Código que deve rodar ao carregar o UserControl
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new UcPaginaInicial());
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
