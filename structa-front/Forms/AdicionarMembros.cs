using structa_front.Models;
using structa_front.Services;
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
    public partial class AdicionarMembros : Form
    {
        public AdicionarMembros()
        {
            InitializeComponent();
        }

        private async void AdicionarMembros_Load(object sender, EventArgs e)
        {
            try
            {
                // Carregar funções
                comboFuncao.Items.Add("Membro");
                comboFuncao.Items.Add("Administrador");
                comboFuncao.Items.Add("Gerente de Projeto");
                comboFuncao.SelectedIndex = 0;

                // Carregar lista de projetos
                // Carregar lista de projetos
                var projetosService = new ProjetosService();

                // PEGAR O USUÁRIO LOGADO
                int usuarioId = Sessao.UsuarioId;

                // BUSCAR APENAS OS PROJETOS DO USUÁRIO
                var projetos = await projetosService.BuscarProjetosAsync(usuarioId);

                comboProjetos.DataSource = projetos;
                comboProjetos.DisplayMember = "Nome";
                comboProjetos.ValueMember = "Id";

                // Atualizar lista de membros do projeto selecionado
                await AtualizarListaMembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar projetos: " + ex.Message);
            }
        }

        private async void comboProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            await AtualizarListaMembros();
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string funcao = comboFuncao.SelectedItem?.ToString() ?? "";
                int idProjeto = (int)comboProjetos.SelectedValue;

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Digite um email.");
                    return;
                }

                var usuariosService = new UsuariosService();
                var membrosService = new MembrosProjetoService();

                // 1 — Buscar usuário pelo email
                var usuario = await usuariosService.BuscarUsuarioPorEmailAsync(email);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                // 2 — Verificar duplicidade
                var membrosExistentes = await membrosService.BuscarMembrosAsync(idProjeto);
                bool jaMembro = membrosExistentes.Exists(m => m.IdUsuario == usuario.Id);

                if (jaMembro)
                {
                    MessageBox.Show("Este usuário já é membro desse projeto.");
                    return;
                }

                // 3 — Criar registro em membros_projetos
                await membrosService.CriarMembroProjeto(
                    usuario.Id,
                    funcao,
                    idProjeto
                );

                MessageBox.Show("Usuário adicionado com sucesso!");

                // 4 — Atualizar lista de membros
                await AtualizarListaMembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar membro: " + ex.Message);
            }
        }

        private async Task AtualizarListaMembros()
        {
            try
            {
                if (comboProjetos.SelectedValue == null) return;

                int idProjeto = (int)comboProjetos.SelectedValue;
                var membrosService = new MembrosProjetoService();

                var membrosComUsuarios = await membrosService.BuscarMembrosComDadosAsync(idProjeto);

                listMembros.Items.Clear(); // listMembros é o ListBox no seu Form

                foreach (var (membro, usuario) in membrosComUsuarios)
                {
                    listMembros.Items.Add($"{usuario.Nome} - {membro.Funcao}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar membros: " + ex.Message);
            }
        }
    }
}
