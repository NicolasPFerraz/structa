using structa_front.Services;
using structa_front.Models;
using System.Text.Json;

namespace structa_front
{
    public partial class NovaAreaDeTrabalho : Form
    {
        private readonly DatabaseService? _db = ServiceProvider.Database;

        public NovaAreaDeTrabalho()
        {
            InitializeComponent();
            if (_db == null)
            {
                throw new InvalidOperationException("DatabaseService not initialized");
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
