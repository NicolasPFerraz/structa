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

            // Placeholder para txtUser
          
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
    }
}
