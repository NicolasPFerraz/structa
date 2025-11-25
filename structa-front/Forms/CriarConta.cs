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
    public partial class CriarConta : BaseForm
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void CriarConta_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = new Models.Usuario
            {
                Nome = txtNomeUsuario.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
            };

            var usuarioService = new Services.UsuariosService();
            try
            {
                var result = await usuarioService.CriarUsuarioAsync(usuario);

                CriarConta2 criarConta2 = new CriarConta2();
                criarConta2.Show(); 
                this.Hide();

                Sessao.UsuarioId = result.Id;
                // Redirecione ou limpe o formulário conforme necessário
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

        private void roundedPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
