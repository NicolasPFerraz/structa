namespace structa_front
{
    partial class Person
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
            this.LBL_textAjuda = new System.Windows.Forms.Label();
            this.BTN_Profissional = new System.Windows.Forms.Button();
            this.BTN_Pessoal = new System.Windows.Forms.Button();
            this.BTN_Estudante = new System.Windows.Forms.Button();
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
            this.LBL_Logo.TabIndex = 0;
            this.LBL_Logo.Text = "Structa";
            this.LBL_Logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBL_textAjuda
            // 
            this.LBL_textAjuda.AutoSize = true;
            this.LBL_textAjuda.Font = new System.Drawing.Font("Arial Unicode MS", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_textAjuda.ForeColor = System.Drawing.Color.White;
            this.LBL_textAjuda.Location = new System.Drawing.Point(120, 257);
            this.LBL_textAjuda.Name = "LBL_textAjuda";
            this.LBL_textAjuda.Size = new System.Drawing.Size(693, 78);
            this.LBL_textAjuda.TabIndex = 1;
            this.LBL_textAjuda.Text = "Como podemos ajuda-lo?";
            // 
            // BTN_Profissional
            // 
            this.BTN_Profissional.Location = new System.Drawing.Point(144, 363);
            this.BTN_Profissional.Name = "BTN_Profissional";
            this.BTN_Profissional.Size = new System.Drawing.Size(133, 35);
            this.BTN_Profissional.TabIndex = 2;
            this.BTN_Profissional.Text = "Profissional";
            this.BTN_Profissional.UseVisualStyleBackColor = true;
            // 
            // BTN_Pessoal
            // 
            this.BTN_Pessoal.Location = new System.Drawing.Point(368, 363);
            this.BTN_Pessoal.Name = "BTN_Pessoal";
            this.BTN_Pessoal.Size = new System.Drawing.Size(133, 35);
            this.BTN_Pessoal.TabIndex = 3;
            this.BTN_Pessoal.Text = "Pessoal";
            this.BTN_Pessoal.UseVisualStyleBackColor = true;
            // 
            // BTN_Estudante
            // 
            this.BTN_Estudante.Location = new System.Drawing.Point(578, 363);
            this.BTN_Estudante.Name = "BTN_Estudante";
            this.BTN_Estudante.Size = new System.Drawing.Size(133, 35);
            this.BTN_Estudante.TabIndex = 4;
            this.BTN_Estudante.Text = "Estudante";
            this.BTN_Estudante.UseVisualStyleBackColor = true;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.BTN_Estudante);
            this.Controls.Add(this.BTN_Pessoal);
            this.Controls.Add(this.BTN_Profissional);
            this.Controls.Add(this.LBL_textAjuda);
            this.Controls.Add(this.LBL_Logo);
            this.Name = "Person";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Logo;
        private System.Windows.Forms.Label LBL_textAjuda;
        private System.Windows.Forms.Button BTN_Profissional;
        private System.Windows.Forms.Button BTN_Pessoal;
        private System.Windows.Forms.Button BTN_Estudante;
    }
}