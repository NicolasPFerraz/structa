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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal(); 
            formPrincipal.Show();
            this.Hide();
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
