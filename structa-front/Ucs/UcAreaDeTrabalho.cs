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
    public partial class UcAreaDeTrabalho : UserControl
    {
        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            PainelConteudo.Controls.Clear();
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Bottom;
            // Adiciona a página ao painel de conteúdo
            PainelConteudo.Controls.Add(pagina);
        }

        public UcAreaDeTrabalho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcPlanoDeGestao());
        }

        private void PainelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
