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
    public partial class CriarConta2 : BaseForm
    {
        public CriarConta2()
        {
            InitializeComponent();
        }

        private void BTN_Pessoal_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Profissional_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Estudante_Click(object sender, EventArgs e)
        {

        }

        private void btnComoAjudar_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcQtdPessoas());
        }

        private void btnQtdPessoas_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcQtdPessoas());
        }

        public void AbrirPagina(UserControl pagina)
        {
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Fill;
            // Adiciona a página ao painel de conte��do
            panelQtdPessoas.Controls.Add(pagina);
        }

        private void panelQtdPessoas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelComoAjudar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
