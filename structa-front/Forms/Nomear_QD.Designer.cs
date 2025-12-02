namespace structa_front
{
    partial class Nomear_QD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Add_Email = new System.Windows.Forms.TextBox();
            this.BTN_add_Membro = new System.Windows.Forms.Button();
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
            this.LBL_Logo.Location = new System.Drawing.Point(120, 83);
            this.LBL_Logo.Name = "LBL_Logo";
            this.LBL_Logo.Size = new System.Drawing.Size(252, 76);
            this.LBL_Logo.TabIndex = 6;
            this.LBL_Logo.Text = "Structa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Convide usúarios para fazer parte desse projeto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chame amigos para fazer parte desse projeto";
            // 
            // TXT_Add_Email
            // 
            this.TXT_Add_Email.Location = new System.Drawing.Point(133, 291);
            this.TXT_Add_Email.Multiline = true;
            this.TXT_Add_Email.Name = "TXT_Add_Email";
            this.TXT_Add_Email.Size = new System.Drawing.Size(261, 27);
            this.TXT_Add_Email.TabIndex = 9;
            this.TXT_Add_Email.Text = "Adicionar E-mail aqui";
            // 
            // BTN_add_Membro
            // 
            this.BTN_add_Membro.Location = new System.Drawing.Point(133, 349);
            this.BTN_add_Membro.Name = "BTN_add_Membro";
            this.BTN_add_Membro.Size = new System.Drawing.Size(143, 23);
            this.BTN_add_Membro.TabIndex = 10;
            this.BTN_add_Membro.Text = "Adicionar membro+";
            this.BTN_add_Membro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::structa_front.Properties.Resources.Image_viewer_amico_2;
            this.pictureBox1.Location = new System.Drawing.Point(877, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Avancar
            // 
            this.BTN_Avancar.Location = new System.Drawing.Point(630, 537);
            this.BTN_Avancar.Name = "BTN_Avancar";
            this.BTN_Avancar.Size = new System.Drawing.Size(143, 32);
            this.BTN_Avancar.TabIndex = 12;
            this.BTN_Avancar.Text = "Avançar";
            this.BTN_Avancar.UseVisualStyleBackColor = true;
            this.BTN_Avancar.Click += new System.EventHandler(this.BTN_Avancar_Click);
            // 
            // Nomear_QD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.BTN_Avancar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_add_Membro);
            this.Controls.Add(this.TXT_Add_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Logo);
            this.Name = "Nomear_QD";
            this.Text = "Nomear_QD";
            this.Load += new System.EventHandler(this.Nomear_QD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Add_Email;
        private System.Windows.Forms.Button BTN_add_Membro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Avancar;
    }
}