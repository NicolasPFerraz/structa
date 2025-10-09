namespace structa_front
{
    partial class NomeProjeto
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
            this.LBL_Logo = new System.Windows.Forms.Label();
            this.LBL_textquadro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NomeProjeto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Logo
            // 
            this.LBL_Logo.AutoSize = true;
            this.LBL_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Logo.ForeColor = System.Drawing.Color.White;
            this.LBL_Logo.Location = new System.Drawing.Point(47, 46);
            this.LBL_Logo.Name = "LBL_Logo";
            this.LBL_Logo.Size = new System.Drawing.Size(252, 76);
            this.LBL_Logo.TabIndex = 6;
            this.LBL_Logo.Text = "Structa";
            // 
            // LBL_textquadro
            // 
            this.LBL_textquadro.AutoSize = true;
            this.LBL_textquadro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_textquadro.ForeColor = System.Drawing.Color.White;
            this.LBL_textquadro.Location = new System.Drawing.Point(48, 169);
            this.LBL_textquadro.Name = "LBL_textquadro";
            this.LBL_textquadro.Size = new System.Drawing.Size(818, 58);
            this.LBL_textquadro.TabIndex = 7;
            this.LBL_textquadro.Text = "Como vamos chamar esse quadro?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "De um nome ao seu quadro ex: Gestão de vendas, \ncontrole de estoque, plano de mar" +
    "keting.";
            // 
            // TXT_NomeProjeto
            // 
            this.TXT_NomeProjeto.Location = new System.Drawing.Point(60, 349);
            this.TXT_NomeProjeto.Multiline = true;
            this.TXT_NomeProjeto.Name = "TXT_NomeProjeto";
            this.TXT_NomeProjeto.Size = new System.Drawing.Size(400, 35);
            this.TXT_NomeProjeto.TabIndex = 9;
            this.TXT_NomeProjeto.Text = "Seu primeiro Projeto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::structa_front.Properties.Resources.Background__2_;
            this.pictureBox1.Location = new System.Drawing.Point(872, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // NomeProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT_NomeProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_textquadro);
            this.Controls.Add(this.LBL_Logo);
            this.Name = "NomeProjeto";
            this.Text = "NomeProjeto";
            this.Load += new System.EventHandler(this.NomeProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Logo;
        private System.Windows.Forms.Label LBL_textquadro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NomeProjeto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}