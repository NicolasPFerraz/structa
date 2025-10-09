using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structa_front
{
    public partial class UcPaginaInicial: UserControl
    {
        public UcPaginaInicial()
        {
            InitializeComponent();
        }
        public void AbrirPagina(UserControl pagina)
        {
            // Limpa o painel de conteúdo
            PainelConteudo.Controls.Clear();
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Bottom;
            // Adiciona a página ao painel de conteúdo
            PainelConteudo.Controls.Add(pagina);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcFeed());
        }

        private void label19_Click(object sender, EventArgs e)
        {
            AbrirPagina(new UcAreaDeTrabalho());
        }
    }
}
