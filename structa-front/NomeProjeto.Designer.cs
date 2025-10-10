namespace structa_front
{
    partial class NomeProjeto : BaseForm
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
            this.BTN_Avancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Logo
            // 
            this.LBL_Logo.AutoSize = true;
            this.LBL_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Logo.ForeColor = System.Drawing.Color.White;
            this.LBL_Logo.Location = new System.Drawing.Point(20, 33);
            this.LBL_Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Logo.Name = "LBL_Logo";
            this.LBL_Logo.Size = new System.Drawing.Size(205, 63);
            this.LBL_Logo.TabIndex = 6;
            this.LBL_Logo.Text = "Structa";
            // 
            // LBL_textquadro
            // 
            this.LBL_textquadro.AutoSize = true;
            this.LBL_textquadro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_textquadro.ForeColor = System.Drawing.Color.White;
            this.LBL_textquadro.Location = new System.Drawing.Point(24, 115);
            this.LBL_textquadro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_textquadro.Name = "LBL_textquadro";
            this.LBL_textquadro.Size = new System.Drawing.Size(567, 39);
            this.LBL_textquadro.TabIndex = 7;
            this.LBL_textquadro.Text = "Como vamos chamar esse quadro?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "De um nome ao seu quadro ex: Gestão de vendas, \ncontrole de estoque, plano de mar" +
    "keting.";
            // 
            // TXT_NomeProjeto
            // 
            this.TXT_NomeProjeto.Location = new System.Drawing.Point(31, 261);
            this.TXT_NomeProjeto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXT_NomeProjeto.Multiline = true;
            this.TXT_NomeProjeto.Name = "TXT_NomeProjeto";
            this.TXT_NomeProjeto.Size = new System.Drawing.Size(301, 29);
            this.TXT_NomeProjeto.TabIndex = 9;
            this.TXT_NomeProjeto.Text = "Seu primeiro Projeto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::structa_front.Properties.Resources.Image_viewer_amico_2;
            this.pictureBox1.Location = new System.Drawing.Point(604, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Avancar
            // 
            this.BTN_Avancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Avancar.Location = new System.Drawing.Point(415, 356);
            this.BTN_Avancar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Avancar.Name = "BTN_Avancar";
            this.BTN_Avancar.Size = new System.Drawing.Size(110, 34);
            this.BTN_Avancar.TabIndex = 11;
            this.BTN_Avancar.Text = "Avançar";
            this.BTN_Avancar.UseVisualStyleBackColor = true;
            this.BTN_Avancar.Click += new System.EventHandler(this.BTN_Avancar_Click);
            // 
            // NomeProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.BTN_Avancar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT_NomeProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_textquadro);
            this.Controls.Add(this.LBL_Logo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1084, 739);
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
        private System.Windows.Forms.Button BTN_Avancar;
    }
}