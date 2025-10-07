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
    public partial class Notificacoes: Form
    {
        public Notificacoes()
        {
            InitializeComponent();
        }

        private void Notificacoes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblNotificacoesTodas_Click(object sender, EventArgs e)
        {
            lblNotificacoesTodas.Font = new Font(lblNotificacoesTodas.Font, FontStyle.Bold);
            lblNotificacoesComMencao.Font = new Font(lblNotificacoesComMencao.Font, FontStyle.Regular);
            lblNotificacoesAtribuidasAMim.Font = new Font(lblNotificacoesAtribuidasAMim.Font, FontStyle.Regular);
        }

        private void lblNotificacoesComMencao_Click(object sender, EventArgs e)
        {
            lblNotificacoesTodas.Font = new Font(lblNotificacoesTodas.Font, FontStyle.Regular);
            lblNotificacoesComMencao.Font = new Font(lblNotificacoesComMencao.Font, FontStyle.Bold);
            lblNotificacoesAtribuidasAMim.Font = new Font(lblNotificacoesAtribuidasAMim.Font, FontStyle.Regular);
        }

        private void lblNotificacoesAtribuidasAMim_Click(object sender, EventArgs e)
        {
            lblNotificacoesTodas.Font = new Font(lblNotificacoesTodas.Font, FontStyle.Regular);
            lblNotificacoesComMencao.Font = new Font(lblNotificacoesComMencao.Font, FontStyle.Regular);
            lblNotificacoesAtribuidasAMim.Font = new Font(lblNotificacoesAtribuidasAMim.Font, FontStyle.Bold);
        }
    }
}
