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
    public partial class FormPrincipal : BaseForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPerfil());
        }

        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            panelConteudo.Controls.Clear();
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Fill;
            // Adiciona a página ao painel de conte��do
            panelConteudo.Controls.Add(pagina);
        }

    }
}
