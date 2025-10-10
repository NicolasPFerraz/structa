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
    public partial class UcQtdPessoas : UserControl
    {
        public UcQtdPessoas()
        {
            InitializeComponent();
        }

        private void panelQtdPessoas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
          NomeProjeto nomeProjeto = new NomeProjeto();
            nomeProjeto.Show();
            this.Hide();
        }
    }
}
