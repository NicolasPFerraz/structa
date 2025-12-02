using structa_front.Forms;
using structa_front.Models;
using structa_front.Services;

namespace structa_front
{
    public partial class CriarConta : BaseForm
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }
        private void CriarConta_Load(object sender, EventArgs e) { }
        private void txtUser_TextChanged(object sender, EventArgs e) { }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Monta o usuário
            var usuario = new Usuario
            {
                Nome = txtNomeUsuario.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Descricao = "",
                DataNascimento = null,
                Localizacao = "",
                Telefone = "",
                LinkRedeSocial = "",
                FusoHorario = "",
                CapacidadeHorasSemanal = null,
                Status = "Ativo",
                DataCriacao = DateTime.UtcNow,
                DataUltimaAlteracao = DateTime.UtcNow
            };

            // 2. Verifica senhas
            if (usuario.Senha != txtSenhaConfirmada.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            try
            {
                var usuarioService = new UsuariosService();

                // 3. Cadastra no Supabase
                var usuarioCriado = await usuarioService.CriarUsuarioAsync(usuario);

                // 4. Salva no Session
                Sessao.UsuarioId= usuarioCriado.Id;

                // 5. Redireciona para a próxima tela
                CriarConta2 criarConta2 = new CriarConta2();
                criarConta2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar usuário: " + ex.Message);
            }
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
