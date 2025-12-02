namespace structa_front
{
    partial class Painel_Perfil
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
            lblEmail = new Label();
            lblNome = new Label();
            LBL_nav = new Label();
            PG_StatusTrabalho = new PictureBox();
            PG_Senha = new PictureBox();
            PG_Pessoal = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PG_StatusTrabalho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PG_Senha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PG_Pessoal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(107, 32);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 13);
            lblEmail.TabIndex = 33;
            lblEmail.Text = "Mark@simmmple.com";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(107, 59);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(121, 20);
            lblNome.TabIndex = 32;
            lblNome.Text = "Mark Johnson";
            // 
            // LBL_nav
            // 
            LBL_nav.AutoSize = true;
            LBL_nav.ForeColor = Color.White;
            LBL_nav.Location = new Point(18, 15);
            LBL_nav.Margin = new Padding(4, 0, 4, 0);
            LBL_nav.Name = "LBL_nav";
            LBL_nav.Size = new Size(86, 15);
            LBL_nav.TabIndex = 24;
            LBL_nav.Text = "Páginas - Perfil";
            // 
            // PG_StatusTrabalho
            // 
            PG_StatusTrabalho.Cursor = Cursors.Hand;
            PG_StatusTrabalho.Image = Properties.Resources.Frame_178;
            PG_StatusTrabalho.Location = new Point(151, 139);
            PG_StatusTrabalho.Margin = new Padding(2);
            PG_StatusTrabalho.Name = "PG_StatusTrabalho";
            PG_StatusTrabalho.Size = new Size(135, 34);
            PG_StatusTrabalho.SizeMode = PictureBoxSizeMode.AutoSize;
            PG_StatusTrabalho.TabIndex = 64;
            PG_StatusTrabalho.TabStop = false;
            PG_StatusTrabalho.Click += PG_StatusTrabalho_Click;
            // 
            // PG_Senha
            // 
            PG_Senha.Cursor = Cursors.Hand;
            PG_Senha.Image = Properties.Resources.Frame_180;
            PG_Senha.Location = new Point(290, 139);
            PG_Senha.Margin = new Padding(2);
            PG_Senha.Name = "PG_Senha";
            PG_Senha.Size = new Size(135, 34);
            PG_Senha.SizeMode = PictureBoxSizeMode.AutoSize;
            PG_Senha.TabIndex = 62;
            PG_Senha.TabStop = false;
            PG_Senha.Click += PG_Senha_Click;
            // 
            // PG_Pessoal
            // 
            PG_Pessoal.BorderStyle = BorderStyle.FixedSingle;
            PG_Pessoal.Cursor = Cursors.Hand;
            PG_Pessoal.Image = Properties.Resources.Frame_177__1_;
            PG_Pessoal.Location = new Point(10, 139);
            PG_Pessoal.Margin = new Padding(2);
            PG_Pessoal.Name = "PG_Pessoal";
            PG_Pessoal.Size = new Size(137, 36);
            PG_Pessoal.SizeMode = PictureBoxSizeMode.AutoSize;
            PG_Pessoal.TabIndex = 61;
            PG_Pessoal.TabStop = false;
            PG_Pessoal.Click += PG_Pessoal_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.Icon;
            pictureBox15.Location = new Point(69, 71);
            pictureBox15.Margin = new Padding(2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(20, 21);
            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox15.TabIndex = 31;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.Image;
            pictureBox14.Location = new Point(34, 32);
            pictureBox14.Margin = new Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(58, 63);
            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox14.TabIndex = 30;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background__1_;
            pictureBox1.Location = new Point(16, 18);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1147, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Painel_Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 76);
            Controls.Add(PG_StatusTrabalho);
            Controls.Add(PG_Senha);
            Controls.Add(PG_Pessoal);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox1);
            Controls.Add(LBL_nav);
            Margin = new Padding(2);
            Name = "Painel_Perfil";
            Size = new Size(1388, 237);
            Load += Painel_Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)PG_StatusTrabalho).EndInit();
            ((System.ComponentModel.ISupportInitialize)PG_Senha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PG_Pessoal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_nav;
        private System.Windows.Forms.PictureBox PG_StatusTrabalho;
        private System.Windows.Forms.PictureBox PG_Senha;
        private System.Windows.Forms.PictureBox PG_Pessoal;
    }
}