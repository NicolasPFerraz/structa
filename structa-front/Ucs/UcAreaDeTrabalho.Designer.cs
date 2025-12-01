namespace structa_front
{
    partial class UcAreaDeTrabalho
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label16 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            PainelConteudo = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PainelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(370, 227);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(343, 48);
            label16.TabIndex = 23;
            label16.Text = "Área de trabalho";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LineSeparator;
            pictureBox3.Location = new Point(123, 519);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1133, 1);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ImgAreadeTabalhoIcon;
            pictureBox2.Location = new Point(165, 157);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImagemAreadeTrabalho;
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1400, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PainelConteudo
            // 
            PainelConteudo.Controls.Add(label1);
            PainelConteudo.Controls.Add(pictureBox2);
            PainelConteudo.Controls.Add(pictureBox1);
            PainelConteudo.Controls.Add(label16);
            PainelConteudo.Controls.Add(pictureBox3);
            PainelConteudo.Location = new Point(0, 4);
            PainelConteudo.Margin = new Padding(5, 4, 5, 4);
            PainelConteudo.Name = "PainelConteudo";
            PainelConteudo.Size = new Size(1400, 923);
            PainelConteudo.TabIndex = 31;
            PainelConteudo.Paint += PainelConteudo_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 485);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 26;
            label1.Text = "Meus projetos";
            // 
            // UcAreaDeTrabalho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 20, 47);
            Controls.Add(PainelConteudo);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UcAreaDeTrabalho";
            Size = new Size(1400, 923);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PainelConteudo.ResumeLayout(false);
            PainelConteudo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel PainelConteudo;
        private Label label1;
    }
}
