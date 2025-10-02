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
            roundedPanel.Left = (this.ClientSize.Width - roundedPanel.Width) / 2;
            roundedPanel.Top = (this.ClientSize.Height - roundedPanel.Height) / 2;

            // Placeholder para txtUser
            txtUser.Enter += (s, e) => {
                if (txtUser.Text == "Digite seu nome ou e-mail") {
                    txtUser.Text = "";
                    txtUser.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtUser.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtUser.Text)) {
                    txtUser.Text = "Digite seu nome ou e-mail";
                    txtUser.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // Placeholder para txtPassword
            txtPassword.Enter += (s, e) => {
                if (txtPassword.Text == "Digite sua senha") {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = System.Drawing.Color.Black;
                    txtPassword.UseSystemPasswordChar = true;
                }
            };
            txtPassword.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                    txtPassword.Text = "Digite sua senha";
                    txtPassword.ForeColor = System.Drawing.Color.Gray;
                    txtPassword.UseSystemPasswordChar = false;
                }
            };
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

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
