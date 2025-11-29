using structa_front.Models;
using structa_front.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structa_front
{
    public partial class Notificacao : UserControl
    {
        private readonly NotificacoesService _notService = new NotificacoesService();

        public Notificacao()
        {
            InitializeComponent();
            Load += Notificacao_Load;
        }

        private async void Notificacao_Load(object? sender, EventArgs e)
        {
            await CarregarNotificacoesAsync();
        }

        private async Task CarregarNotificacoesAsync()
        {

        }

        private async void Lst_DoubleClick(object? sender, EventArgs e)
        {
        }

        // Pequeno wrapper para exibir texto e guardar id no ListBox (se usar ListBox)
        private class ListBoxItemWrapper
        {
            public int Id { get; }
            public string Text { get; }

            public ListBoxItemWrapper(int id, string text)
            {
                Id = id;
                Text = text;
            }

            public override string ToString() => Text;
        }
    }
}