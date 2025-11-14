using structa_front.Services;
using structa_front.Models;
using System.Text.Json;

namespace structa_front
{
    public partial class NovaAreaDeTrabalho : Form
    {
        private readonly DatabaseService _db;

        public NovaAreaDeTrabalho()
        {
            InitializeComponent();

            _db = new DatabaseService();
            _ = InicializarSupabase();
        }

        private async Task InicializarSupabase()
        {
            await _db.InicializarAsync(); // nome certo
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_db.IsReady)
            {
                MessageBox.Show("Banco ainda carregando...");
                return;
            }

            var usuarios = await _db.BuscarUsuariosAsync();

            if (usuarios.Count > 0)
            {
                MessageBox.Show("Primeiro usuário: " + usuarios[0].Nome);
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado.");
            }
        }
    }
}
