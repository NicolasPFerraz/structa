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

namespace structa_front
{
    public partial class Senha : UserControl
    {
        public Senha()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var usuarioService = new Services.UsuariosService();
            try
            {
                var result = await usuarioService.VerificarSenhaAsync(Sessao.UsuarioId, txtSenhaAtual.Text);
                if (result == null)
                {
                    throw new Exception("senha atual incorreta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar senha: " + ex.Message);
                return;
            }

            if (txtNovaSenha.Text != txtNovaSenhaConfirmada.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            try
            {
                var usuario = await usuarioService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                usuario.Senha = txtNovaSenha.Text; 
                var result = await usuarioService.AtualizarUsuarioAsync(usuario);
                MessageBox.Show("Senha atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a senha: " + ex.Message);
            }
        }

        private void Senha_Load(object sender, EventArgs e)
        {

        }
    }
}