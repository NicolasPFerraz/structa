using structa_front.Forms;
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
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
            // Centraliza o painel customizado
            roundedPanel1.Left = (this.ClientSize.Width - roundedPanel1.Width) / 2;
            roundedPanel1.Top = (this.ClientSize.Height - roundedPanel1.Height) / 2;          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centraliza o painel customizado ao redimensionar
            roundedPanel.Left = (this.ClientSize.Width - roundedPanel.Width) / 2;
            roundedPanel.Top = (this.ClientSize.Height - roundedPanel.Height) / 2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void roundedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginDesc_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSenhaConfirmada_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            criarConta.Show();
            this.Hide();
        }

        private void lblRegistrar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblRegistrar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lblLoginTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal("Página");
            formPrincipal.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            EsqueciASenha esqueciASenha = new EsqueciASenha();
            esqueciASenha.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
