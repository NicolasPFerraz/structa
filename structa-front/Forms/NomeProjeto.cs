using structa_front.Forms;
using structa_front.Models;
using structa_front.Services;
using System;
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

        private async void BTN_Avancar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< Updated upstream
            Nomear_QD nomear_QD = new Nomear_QD(); 
            nomear_QD.Show();
            this.Hide();
=======
=======
            // 1 — Validar campo vazio
>>>>>>> 78a8a74efbb6aab6cfc3dd03800a4c09ff3fc7b8
            if (string.IsNullOrWhiteSpace(TXT_NomeProjeto.Text))
            {
                MessageBox.Show("Digite um nome para o projeto.");
                return;
            }

            try
            {
<<<<<<< HEAD
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
=======
                // 2 — Criar instância do serviço
                var projetosService = new ProjetosService();

                // 3 — Buscar usuário logado
                var usuarioService = new UsuariosService();
                var usuario = await usuarioService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);

                if (usuario == null)
                {
                    MessageBox.Show("Erro: usuário não encontrado.");
                    return;
                }

                // 4 — Criar o projeto no Supabase
                var projetoCriado = await projetosService.CriarProjetoAsync(
                    TXT_NomeProjeto.Text,   // Nome do projeto digitado
                    "TESTE",
                    Sessao.UsuarioId // Nome do responsável
                );

                if (projetoCriado != null)
                {
                    // Define projeto atual na sessão para que outros controles usem o id
                    Sessao.ProjetoId = projetoCriado.Id;
                }

                // 5 — Avançar para próxima tela
>>>>>>> 78a8a74efbb6aab6cfc3dd03800a4c09ff3fc7b8
                Nomear_QD nomear_QD = new Nomear_QD();
                nomear_QD.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o projeto: " + ex.Message);
            }
        }

<<<<<<< HEAD

        private void TXT_NomeProjeto_TextChanged(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
=======
        private void TXT_NomeProjeto_TextChanged(object sender, EventArgs e)
        {

>>>>>>> 78a8a74efbb6aab6cfc3dd03800a4c09ff3fc7b8
        }
    }
}
