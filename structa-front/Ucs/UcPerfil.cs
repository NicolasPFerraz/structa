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
    public partial class panel : UserControl
    {
        private readonly UsuariosService _usuariosService = new UsuariosService();

        public panel()
        {
            InitializeComponent();

            // Associa o evento do botão Salvar
            btnSalvarAlteracoes.Click += BtnSalvarAlteracoes_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void UcPerfil_Load(object sender, EventArgs e)
        {
            await CarregarUsuarioAsync();
        }

        private async Task CarregarUsuarioAsync()
        {
            try
            {
                if (Sessao.UsuarioId <= 0)
                {
                    // Não há sessão ativa
                    return;
                }

                var usuario = await _usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                // Preenche os controles com os dados do usuário
                txtNome.Text = usuario.Nome ?? string.Empty;
                txtEmail.Text = usuario.Email ?? string.Empty;
                txtTelefone.Text = usuario.Telefone ?? string.Empty;
                txtLocal.Text = usuario.Localizacao ?? string.Empty;
                txtDescricao.Text = usuario.Descricao ?? string.Empty;

                if (usuario.DataNascimento.HasValue)
                {
                    dtNascimento.Value = usuario.DataNascimento.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do perfil: " + ex.Message);
            }
        }

        private async void BtnSalvarAlteracoes_Click(object? sender, EventArgs e)
        {
            try
            {
                if (Sessao.UsuarioId <= 0)
                {
                    MessageBox.Show("Nenhum usuário logado.");
                    return;
                }

                // Busca o usuário atual para manter campos que não estão no formulário (ex: senha)
                var usuarioExistente = await _usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                if (usuarioExistente == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                // Atualiza somente os campos editáveis pela UI
                usuarioExistente.Nome = txtNome.Text.Trim();
                usuarioExistente.Email = txtEmail.Text.Trim();
                usuarioExistente.Telefone = txtTelefone.Text.Trim();
                usuarioExistente.Localizacao = txtLocal.Text.Trim();
                usuarioExistente.Descricao = txtDescricao.Text.Trim();
                usuarioExistente.DataNascimento = dtNascimento.Value;

                var atualizado = await _usuariosService.AtualizarUsuarioAsync(usuarioExistente);

                if (atualizado != null)
                {
                    MessageBox.Show("Perfil atualizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o perfil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panelIdioma_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StatusTrabalho statusTrabalho = new StatusTrabalho();
            statusTrabalho.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Cronograma cronograma = new Cronograma();
            cronograma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}