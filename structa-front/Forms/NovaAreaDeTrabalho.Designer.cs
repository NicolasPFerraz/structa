namespace structa_front
{
    partial class NovaAreaDeTrabalho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPesquisarNotificacoes = new TextBox();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisarNotificacoes
            // 
            txtPesquisarNotificacoes.Font = new Font("Segoe UI", 11F);
            txtPesquisarNotificacoes.ForeColor = Color.Gray;
            txtPesquisarNotificacoes.ImeMode = ImeMode.NoControl;
            txtPesquisarNotificacoes.Location = new Point(32, 137);
            txtPesquisarNotificacoes.Margin = new Padding(5, 4, 5, 4);
            txtPesquisarNotificacoes.Name = "txtPesquisarNotificacoes";
            txtPesquisarNotificacoes.Size = new Size(447, 32);
            txtPesquisarNotificacoes.TabIndex = 40;
            txtPesquisarNotificacoes.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(445, 39);
            label1.TabIndex = 36;
            label1.Text = "Criar nova área de trabalho";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.LineSeparator;
            pictureBox6.Location = new Point(32, 127);
            pictureBox6.Margin = new Padding(5, 4, 5, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(651, 1);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(489, 137);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 41);
            btnLogin.TabIndex = 41;
            btnLogin.Text = "Criar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // NovaAreaDeTrabalho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 20, 47);
            ClientSize = new Size(737, 692);
            Controls.Add(btnLogin);
            Controls.Add(txtPesquisarNotificacoes);
            Controls.Add(pictureBox6);
            Controls.Add(label1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "NovaAreaDeTrabalho";
            Text = "NovaAreaDeTrabalho";
            Load += NovaAreaDeTrabalho_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisarNotificacoes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}