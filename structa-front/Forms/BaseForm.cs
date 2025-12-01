using System.Drawing;
using System.Windows.Forms;

namespace structa_front.Forms
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Define tamanho padrão e opções comuns para todos os formulários
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1440, 900);
            MinimumSize = new Size(1440, 900);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // BaseForm
            // 
            ClientSize = new Size(1422, 761);
            Name = "BaseForm";
            ResumeLayout(false);

        }
    }
}
