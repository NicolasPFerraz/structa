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
    public partial class Nomear_QD : Form
    {
        public Nomear_QD()
        {
            InitializeComponent();
            CriarConta2 criarConta2 = new CriarConta2();
            criarConta2.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Avancar_Click(object sender, EventArgs e)
        {
         FormPrincipal formPrincipal = new FormPrincipal("");
            formPrincipal.Show();
            this.Hide();
        }

        private void Nomear_QD_Load(object sender, EventArgs e)
        {

        }
    }
}
