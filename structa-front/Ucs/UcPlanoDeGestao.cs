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
    public partial class UcPlanoDeGestao : UserControl
    {
        bool tarefa = false;
        private void UcPlanoDeGestao_Load(object sender, EventArgs e)
        {
   
        }

        public void AbrirPagina(UserControl pagina)
        {
            // Configura a página para preencher o painel
            pagina.Dock = DockStyle.Fill;
            // Adiciona a página ao painel de conte��do
            uctarefas.Controls.Add(pagina);
        }

        public void FecharPagina()
        {
            // Limpa o painel de conteúdo
            uctarefas.Controls.Clear();
        }

        public UcPlanoDeGestao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(tarefa == false)
            {
                AbrirPagina(new UcTarefasPlanoDeGestao());
                tarefa = true;
            }
            else if(tarefa == true)
            {
                FecharPagina();
                tarefa = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tarefa == false)
            {
                AbrirPagina(new UcTarefasPlanoDeGestao());
                tarefa = true;
            }
            else if (tarefa == true)
            {
                FecharPagina();
                tarefa = false;
            }
        }

    }
}
