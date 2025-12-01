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
                comboFuncao.Items.Add("Membro");
                comboFuncao.Items.Add("Administrador");
                comboFuncao.Items.Add("Gerente de Projeto");
                comboFuncao.SelectedIndex = 0;

                var projetosService = new ProjetosService();
                int usuarioId = Sessao.UsuarioId;
                var projetos = await projetosService.BuscarProjetosAsync(usuarioId);

                comboProjetos.DataSource = projetos;
                comboProjetos.DisplayMember = "Nome";
                comboProjetos.ValueMember = "Id";

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
                if (!await UsuarioPodeGerenciarMembros())
                {
                    MessageBox.Show("Apenas Administradores ou Gerentes de Projeto podem adicionar membros.");
                    return;
                }

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

                var usuario = await usuariosService.BuscarUsuarioPorEmailAsync(email);
                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                var membrosExistentes = await membrosService.BuscarMembrosAsync(idProjeto);
                if (membrosExistentes.Exists(m => m.IdUsuario == usuario.Id))
                {
                    MessageBox.Show("Este usuário já é membro desse projeto.");
                    return;
                }

                await membrosService.CriarMembroProjeto(usuario.Id, funcao, idProjeto);
                MessageBox.Show("Usuário adicionado com sucesso!");
                await AtualizarListaMembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar membro: " + ex.Message);
            }
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int idProjeto = (int)comboProjetos.SelectedValue;
                var membrosService = new MembrosProjetoService();
                var membrosComUsuarios = await membrosService.BuscarMembrosComDadosAsync(idProjeto);

                if (comboRemoverMembro.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um membro para remover.");
                    return;
                }

                string selecionado = comboRemoverMembro.SelectedItem.ToString();
                int idMembroParaRemover = -1;

                if (selecionado == "Remover a mim mesmo")
                {
                    var meuMembro = membrosComUsuarios.FirstOrDefault(m => m.Item2.Id == Sessao.UsuarioId);
                    if (meuMembro.Item1 != null)
                        idMembroParaRemover = meuMembro.Item1.Id;
                }
                else
                {
                    var membro = membrosComUsuarios.FirstOrDefault(m =>
                        $"{m.Item2.Nome} - {m.Item1.Funcao}" == selecionado);

                    if (membro.Item1 != null)
                    {
                        if (!await UsuarioPodeGerenciarMembros())
                        {
                            MessageBox.Show("Apenas Administradores ou Gerentes de Projeto podem remover outros membros.");
                            return;
                        }
                        idMembroParaRemover = membro.Item1.Id;
                    }
                }

                if (idMembroParaRemover == -1)
                {
                    MessageBox.Show("Não foi possível identificar o membro para remover.");
                    return;
                }

                bool sucesso = await membrosService.RemoverMembroAsync(idMembroParaRemover);
                if (sucesso)
                {
                    MessageBox.Show("Membro removido com sucesso!");
                    await AtualizarListaMembros();
                }
                else
                {
                    MessageBox.Show("Falha ao remover membro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover membro: " + ex.Message);
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

                listMembros.Items.Clear();
                foreach (var (membro, usuario) in membrosComUsuarios)
                    listMembros.Items.Add($"{usuario.Nome} - {membro.Funcao}");

                comboRemoverMembro.Items.Clear();
                comboRemoverMembro.Items.Add("Remover a mim mesmo");
                foreach (var (membro, usuario) in membrosComUsuarios)
                    comboRemoverMembro.Items.Add($"{usuario.Nome} - {membro.Funcao}");

                comboRemoverMembro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar membros: " + ex.Message);
            }
        }

        private async Task<bool> UsuarioPodeGerenciarMembros()
        {
            int idProjeto = (int)comboProjetos.SelectedValue;
            var membrosService = new MembrosProjetoService();
            var membros = await membrosService.BuscarMembrosAsync(idProjeto);
            var meuMembro = membros.FirstOrDefault(m => m.IdUsuario == Sessao.UsuarioId);

            if (meuMembro == null) return false;

            return meuMembro.Funcao == "Administrador" || meuMembro.Funcao == "Gerente de Projeto";
        }
    }
}
