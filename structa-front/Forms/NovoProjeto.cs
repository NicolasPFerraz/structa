using structa_front.Config;
using structa_front.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using structa_front.Services;

namespace structa_front.Forms
{
    public partial class NovoProjeto : Form
    {
        public NovoProjeto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string nomeProjeto = txt_nomeprojeto.Text.Trim();
            string descricao = txt_descricao.Text.Trim();

            if (string.IsNullOrEmpty(nomeProjeto))
            {
                MessageBox.Show("Digite um nome para o projeto.");
                return;
            }

            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Digite uma descrição para o projeto.");
                return;
            }

            btn_criar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var projetoService = new Services.ProjetosService();
                var projeto = await projetoService.CriarProjetoAsync(nomeProjeto, Sessao.Nome, Sessao.UsuarioId);

                if (projeto != null)
                {
                    MessageBox.Show("Projeto criado com sucesso!");

                    // Notifica interessados que a lista de projetos foi atualizada
                    ProjectEvents.RaiseProjectsUpdated();

                    this.Close(); // <-- fecha o formulário atual
                }
                else
                {
                    MessageBox.Show("Erro ao criar projeto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar projeto: " + ex.Message);
            }
            finally
            {
                btn_criar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
        private void NovoProjeto_Load(object sender, EventArgs e)
        {

        }

        private void txt_nomeprojeto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
