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
    public partial class NomeProjeto : BaseForm
    {
        public NomeProjeto()
        {
            InitializeComponent();
        }

        private void NomeProjeto_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Avancar_Click(object sender, EventArgs e)
        {
            Nomear_QD nomear_QD = new Nomear_QD(); 
            nomear_QD.Show();
            this.Hide();
        }
    }
}
