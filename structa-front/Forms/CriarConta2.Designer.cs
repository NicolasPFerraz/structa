namespace structa_front
{
    partial class CriarConta2
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
            BTN_Estudante = new Button();
            BTN_Pessoal = new Button();
            BTN_Profissional = new Button();
            LBL_textAjuda = new Label();
            LBL_Logo = new Label();
            panelComoAjudar = new RoundedPanel();
            panelQtdPessoas = new Panel();
            pictureBox1 = new PictureBox();
            panelComoAjudar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Estudante
            // 
            BTN_Estudante.Location = new Point(416, 199);
            BTN_Estudante.Margin = new Padding(3, 2, 3, 2);
            BTN_Estudante.Name = "BTN_Estudante";
            BTN_Estudante.Size = new Size(116, 32);
            BTN_Estudante.TabIndex = 9;
            BTN_Estudante.Text = "Estudante";
            BTN_Estudante.UseVisualStyleBackColor = true;
            BTN_Estudante.Click += btnComoAjudar_Click;
            // 
            // BTN_Pessoal
            // 
            BTN_Pessoal.Location = new Point(231, 199);
            BTN_Pessoal.Margin = new Padding(3, 2, 3, 2);
            BTN_Pessoal.Name = "BTN_Pessoal";
            BTN_Pessoal.Size = new Size(116, 32);
            BTN_Pessoal.TabIndex = 8;
            BTN_Pessoal.Text = "Pessoal";
            BTN_Pessoal.UseVisualStyleBackColor = true;
            BTN_Pessoal.Click += btnComoAjudar_Click;
            // 
            // BTN_Profissional
            // 
            BTN_Profissional.Location = new Point(43, 199);
            BTN_Profissional.Margin = new Padding(3, 2, 3, 2);
            BTN_Profissional.Name = "BTN_Profissional";
            BTN_Profissional.Size = new Size(116, 32);
            BTN_Profissional.TabIndex = 7;
            BTN_Profissional.Text = "Profissional";
            BTN_Profissional.UseVisualStyleBackColor = true;
            BTN_Profissional.Click += btnComoAjudar_Click;
            // 
            // LBL_textAjuda
            // 
            LBL_textAjuda.AutoSize = true;
            LBL_textAjuda.Font = new Font("Segoe UI", 22F);
            LBL_textAjuda.ForeColor = Color.White;
            LBL_textAjuda.Location = new Point(35, 133);
            LBL_textAjuda.Name = "LBL_textAjuda";
            LBL_textAjuda.Size = new Size(364, 41);
            LBL_textAjuda.TabIndex = 6;
            LBL_textAjuda.Text = "Como podemos ajuda-lo?";
            // 
            // LBL_Logo
            // 
            LBL_Logo.AutoSize = true;
            LBL_Logo.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Logo.ForeColor = Color.White;
            LBL_Logo.Location = new Point(26, 33);
            LBL_Logo.Name = "LBL_Logo";
            LBL_Logo.Size = new Size(210, 72);
            LBL_Logo.TabIndex = 5;
            LBL_Logo.Text = "Structa";
            // 
            // panelComoAjudar
            // 
            panelComoAjudar.Controls.Add(LBL_Logo);
            panelComoAjudar.Controls.Add(LBL_textAjuda);
            panelComoAjudar.Controls.Add(BTN_Profissional);
            panelComoAjudar.Controls.Add(BTN_Pessoal);
            panelComoAjudar.Controls.Add(BTN_Estudante);
            panelComoAjudar.CornerRadius = 2;
            panelComoAjudar.Location = new Point(0, 0);
            panelComoAjudar.Margin = new Padding(4);
            panelComoAjudar.Name = "panelComoAjudar";
            panelComoAjudar.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            panelComoAjudar.ShadowOffset = 16;
            panelComoAjudar.Size = new Size(648, 372);
            panelComoAjudar.TabIndex = 15;
            panelComoAjudar.Paint += panelComoAjudar_Paint;
            // 
            // panelQtdPessoas
            // 
            panelQtdPessoas.Location = new Point(12, 237);
            panelQtdPessoas.Margin = new Padding(4);
            panelQtdPessoas.Name = "panelQtdPessoas";
            panelQtdPessoas.Size = new Size(695, 609);
            panelQtdPessoas.TabIndex = 16;
            panelQtdPessoas.Paint += panelQtdPessoas_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Image_viewer_rafiki__1__1__2_;
            pictureBox1.Location = new Point(714, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // CriarConta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 12, 40);
            ClientSize = new Size(1424, 807);
            Controls.Add(pictureBox1);
            Controls.Add(panelQtdPessoas);
            Controls.Add(panelComoAjudar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(0, 0);
            Name = "CriarConta2";
            Text = "Person2";
            Click += btnComoAjudar_Click;
            panelComoAjudar.ResumeLayout(false);
            panelComoAjudar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Estudante;
        private System.Windows.Forms.Button BTN_Pessoal;
        private System.Windows.Forms.Button BTN_Profissional;
        private System.Windows.Forms.Label LBL_textAjuda;
        private System.Windows.Forms.Label LBL_Logo;
        private RoundedPanel panelComoAjudar;
        private System.Windows.Forms.Panel panelQtdPessoas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}