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
            this.txtPesquisarNotificacoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisarNotificacoes
            // 
            this.txtPesquisarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPesquisarNotificacoes.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisarNotificacoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPesquisarNotificacoes.Location = new System.Drawing.Point(24, 89);
            this.txtPesquisarNotificacoes.Name = "txtPesquisarNotificacoes";
            this.txtPesquisarNotificacoes.Size = new System.Drawing.Size(337, 27);
            this.txtPesquisarNotificacoes.TabIndex = 40;
            this.txtPesquisarNotificacoes.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Criar nova área de trabalho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::structa_front.Properties.Resources.LineSeparator;
            this.pictureBox6.Location = new System.Drawing.Point(24, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(489, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(367, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 27);
            this.btnLogin.TabIndex = 41;
            this.btnLogin.Text = "Criar";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // NovaAreaDeTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPesquisarNotificacoes);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Name = "NovaAreaDeTrabalho";
            this.Text = "NovaAreaDeTrabalho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisarNotificacoes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}