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
            LBL_Logo = new Label();
            label1 = new Label();
            label2 = new Label();
            TXT_Add_Email = new TextBox();
            BTN_add_Membro = new Button();
            pictureBox1 = new PictureBox();
            BTN_Avancar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LBL_Logo
            // 
            LBL_Logo.AutoSize = true;
            LBL_Logo.Font = new Font("Microsoft Sans Serif", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Logo.ForeColor = Color.White;
            LBL_Logo.Location = new Point(105, 78);
            LBL_Logo.Name = "LBL_Logo";
            LBL_Logo.Size = new Size(205, 63);
            LBL_Logo.TabIndex = 6;
            LBL_Logo.Text = "Structa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 168);
            label1.Name = "label1";
            label1.Size = new Size(521, 26);
            label1.TabIndex = 7;
            label1.Text = "Convide usúarios para fazer parte desse projeto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 218);
            label2.Name = "label2";
            label2.Size = new Size(332, 20);
            label2.TabIndex = 8;
            label2.Text = "Chame amigos para fazer parte desse projeto";
            // 
            // TXT_Add_Email
            // 
            TXT_Add_Email.Location = new Point(116, 273);
            TXT_Add_Email.Multiline = true;
            TXT_Add_Email.Name = "TXT_Add_Email";
            TXT_Add_Email.Size = new Size(229, 26);
            TXT_Add_Email.TabIndex = 9;
            TXT_Add_Email.Text = "Adicionar E-mail aqui";
            // 
            // BTN_add_Membro
            // 
            BTN_add_Membro.Location = new Point(116, 327);
            BTN_add_Membro.Name = "BTN_add_Membro";
            BTN_add_Membro.Size = new Size(125, 22);
            BTN_add_Membro.TabIndex = 10;
            BTN_add_Membro.Text = "Adicionar membro+";
            BTN_add_Membro.UseVisualStyleBackColor = true;
            BTN_add_Membro.Click += BTN_add_Membro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Image_viewer_amico_2;
            pictureBox1.Location = new Point(767, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BTN_Avancar
            // 
            BTN_Avancar.Location = new Point(551, 503);
            BTN_Avancar.Name = "BTN_Avancar";
            BTN_Avancar.Size = new Size(125, 30);
            BTN_Avancar.TabIndex = 12;
            BTN_Avancar.Text = "Avançar";
            BTN_Avancar.UseVisualStyleBackColor = true;
            BTN_Avancar.Click += BTN_Avancar_Click;
            // 
            // Nomear_QD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1244, 792);
            Controls.Add(BTN_Avancar);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_add_Membro);
            Controls.Add(TXT_Add_Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LBL_Logo);
            Name = "Nomear_QD";
            Text = "Nomear_QD";
            Load += Nomear_QD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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