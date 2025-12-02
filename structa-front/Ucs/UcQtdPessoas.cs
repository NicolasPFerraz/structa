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

            // Obtém o formulário pai e o fecha
            var parentForm = this.FindForm(); // Encontra o formulário que contém o UserControl
            if (parentForm != null)
            {
                parentForm.Close(); // Fecha o formulário
            }

        }

        private void BTN_Equipe_G_Click(object sender, EventArgs e)
        {
            btnAvancar.Visible = true;
        }

        private void BTN_Equipe_P_Click(object sender, EventArgs e)
        {
            btnAvancar.Visible = true;
        }

        private void BTN_Solo_Click(object sender, EventArgs e)
        {
            btnAvancar.Visible = true;
        }
    }
}
