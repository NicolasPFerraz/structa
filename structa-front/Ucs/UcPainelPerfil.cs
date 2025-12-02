using System;
using System.Windows.Forms;
using structa_front.Services;
using structa_front.Models;
using System.Threading.Tasks;

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
        }

        private void PG_StatusTrabalho_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new StatusTrabalho());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.FixedSingle;
            PG_Senha.BorderStyle = BorderStyle.None;

        }

        private void PG_Notificacao_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new Notificacao());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.None;
            PG_Senha.BorderStyle = BorderStyle.None;
        }

        private void PG_Senha_Click(object sender, EventArgs e)
        {
            _formPrincipal.AbrirPagina(new Senha());
            PG_Pessoal.BorderStyle = BorderStyle.None;
            PG_StatusTrabalho.BorderStyle = BorderStyle.None;
            PG_Senha.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementar ação
        }

        private async void Painel_Perfil_Load(object sender, EventArgs e)
        {
            // Carrega nome e e-mail do usuário logado
            await CarregarDadosPerfilAsync();
        }

        private async Task CarregarDadosPerfilAsync()
        {
            try
            {
                if (Sessao.UsuarioId <= 0)
                    return;

                var usuariosService = new UsuariosService();
                var usuario = await usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);

                if (usuario != null)
                {
                    lblNome.Text = usuario.Nome ?? string.Empty;
                    lblEmail.Text = usuario.Email ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do perfil: " + ex.Message);
            }
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
