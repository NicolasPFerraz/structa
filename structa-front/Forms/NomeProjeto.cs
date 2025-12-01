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
<<<<<<< Updated upstream
            Nomear_QD nomear_QD = new Nomear_QD(); 
            nomear_QD.Show();
            this.Hide();
=======
            if (string.IsNullOrWhiteSpace(TXT_NomeProjeto.Text))
            {
                MessageBox.Show("Digite um nome para o projeto.");
                return;
            }

            try
            {
                var projetosService = new ProjetosService();

                // Pega o usuário logado
                var usuario = Session.UsuarioLogado;

                if (usuario == null)
                {
                    MessageBox.Show("Erro: usuário não está logado.");
                    return;
                }

                // Cria o projeto
                await projetosService.CriarProjetoAsync(
                    TXT_NomeProjeto.Text,
                    usuario.Nome
                );

                // Avança
                Nomear_QD nomear_QD = new Nomear_QD();
                nomear_QD.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o projeto: " + ex.Message);
            }
        }


        private void TXT_NomeProjeto_TextChanged(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
