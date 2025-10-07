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
            this.BTN_Estudante = new System.Windows.Forms.Button();
            this.BTN_Pessoal = new System.Windows.Forms.Button();
            this.BTN_Profissional = new System.Windows.Forms.Button();
            this.LBL_textAjuda = new System.Windows.Forms.Label();
            this.LBL_Logo = new System.Windows.Forms.Label();
            this.panelComoAjudar = new structa_front.RoundedPanel();
            this.panelQtdPessoas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelComoAjudar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Estudante
            // 
            this.BTN_Estudante.Location = new System.Drawing.Point(564, 293);
            this.BTN_Estudante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Estudante.Name = "BTN_Estudante";
            this.BTN_Estudante.Size = new System.Drawing.Size(133, 34);
            this.BTN_Estudante.TabIndex = 9;
            this.BTN_Estudante.Text = "Estudante";
            this.BTN_Estudante.UseVisualStyleBackColor = true;
            this.BTN_Estudante.Click += new System.EventHandler(this.btnComoAjudar_Click);
            // 
            // BTN_Pessoal
            // 
            this.BTN_Pessoal.Location = new System.Drawing.Point(353, 293);
            this.BTN_Pessoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Pessoal.Name = "BTN_Pessoal";
            this.BTN_Pessoal.Size = new System.Drawing.Size(133, 34);
            this.BTN_Pessoal.TabIndex = 8;
            this.BTN_Pessoal.Text = "Pessoal";
            this.BTN_Pessoal.UseVisualStyleBackColor = true;
            this.BTN_Pessoal.Click += new System.EventHandler(this.btnComoAjudar_Click);
            // 
            // BTN_Profissional
            // 
            this.BTN_Profissional.Location = new System.Drawing.Point(138, 293);
            this.BTN_Profissional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Profissional.Name = "BTN_Profissional";
            this.BTN_Profissional.Size = new System.Drawing.Size(133, 34);
            this.BTN_Profissional.TabIndex = 7;
            this.BTN_Profissional.Text = "Profissional";
            this.BTN_Profissional.UseVisualStyleBackColor = true;
            this.BTN_Profissional.Click += new System.EventHandler(this.btnComoAjudar_Click);
            // 
            // LBL_textAjuda
            // 
            this.LBL_textAjuda.AutoSize = true;
            this.LBL_textAjuda.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.LBL_textAjuda.ForeColor = System.Drawing.Color.White;
            this.LBL_textAjuda.Location = new System.Drawing.Point(129, 223);
            this.LBL_textAjuda.Name = "LBL_textAjuda";
            this.LBL_textAjuda.Size = new System.Drawing.Size(449, 50);
            this.LBL_textAjuda.TabIndex = 6;
            this.LBL_textAjuda.Text = "Como podemos ajuda-lo?";
            // 
            // LBL_Logo
            // 
            this.LBL_Logo.AutoSize = true;
            this.LBL_Logo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.LBL_Logo.ForeColor = System.Drawing.Color.White;
            this.LBL_Logo.Location = new System.Drawing.Point(128, 111);
            this.LBL_Logo.Name = "LBL_Logo";
            this.LBL_Logo.Size = new System.Drawing.Size(165, 57);
            this.LBL_Logo.TabIndex = 5;
            this.LBL_Logo.Text = "Structa";
            // 
            // panelComoAjudar
            // 
            this.panelComoAjudar.Controls.Add(this.LBL_Logo);
            this.panelComoAjudar.Controls.Add(this.LBL_textAjuda);
            this.panelComoAjudar.Controls.Add(this.BTN_Profissional);
            this.panelComoAjudar.Controls.Add(this.BTN_Pessoal);
            this.panelComoAjudar.Controls.Add(this.BTN_Estudante);
            this.panelComoAjudar.CornerRadius = 2;
            this.panelComoAjudar.Location = new System.Drawing.Point(0, 0);
            this.panelComoAjudar.Margin = new System.Windows.Forms.Padding(4);
            this.panelComoAjudar.Name = "panelComoAjudar";
            this.panelComoAjudar.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelComoAjudar.ShadowOffset = 16;
            this.panelComoAjudar.Size = new System.Drawing.Size(740, 397);
            this.panelComoAjudar.TabIndex = 15;
            // 
            // panelQtdPessoas
            // 
            this.panelQtdPessoas.Location = new System.Drawing.Point(0, 405);
            this.panelQtdPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.panelQtdPessoas.Name = "panelQtdPessoas";
            this.panelQtdPessoas.Size = new System.Drawing.Size(794, 650);
            this.panelQtdPessoas.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::structa_front.Properties.Resources.Image_viewer_rafiki__1__1__2_;
            this.pictureBox1.Location = new System.Drawing.Point(816, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CriarConta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelQtdPessoas);
            this.Controls.Add(this.panelComoAjudar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "CriarConta2";
            this.Text = "Person2";
            this.Click += new System.EventHandler(this.btnComoAjudar_Click);
            this.panelComoAjudar.ResumeLayout(false);
            this.panelComoAjudar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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