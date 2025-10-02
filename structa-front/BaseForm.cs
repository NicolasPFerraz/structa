using System.Drawing;
using System.Windows.Forms;

namespace structa_front
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Define tamanho padrão e opções comuns para todos os formulários
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1440, 900);
            this.MinimumSize = new Size(1440, 900);
        }
    }
}
