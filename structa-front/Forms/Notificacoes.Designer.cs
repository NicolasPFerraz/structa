namespace structa_front
{
    partial class Notificacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotificacoesTodas = new System.Windows.Forms.Label();
            this.lblNotificacoesAtribuidasAMim = new System.Windows.Forms.Label();
            this.txtPesquisarNotificacoes = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblNotificacoesComMencao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notificações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNotificacoesTodas
            // 
            this.lblNotificacoesTodas.AutoSize = true;
            this.lblNotificacoesTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotificacoesTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacoesTodas.ForeColor = System.Drawing.Color.White;
            this.lblNotificacoesTodas.Location = new System.Drawing.Point(21, 72);
            this.lblNotificacoesTodas.Name = "lblNotificacoesTodas";
            this.lblNotificacoesTodas.Size = new System.Drawing.Size(42, 13);
            this.lblNotificacoesTodas.TabIndex = 10;
            this.lblNotificacoesTodas.Text = "Todas";
            this.lblNotificacoesTodas.Click += new System.EventHandler(this.lblNotificacoesTodas_Click);
            // 
            // lblNotificacoesAtribuidasAMim
            // 
            this.lblNotificacoesAtribuidasAMim.AutoSize = true;
            this.lblNotificacoesAtribuidasAMim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotificacoesAtribuidasAMim.ForeColor = System.Drawing.Color.White;
            this.lblNotificacoesAtribuidasAMim.Location = new System.Drawing.Point(233, 72);
            this.lblNotificacoesAtribuidasAMim.Name = "lblNotificacoesAtribuidasAMim";
            this.lblNotificacoesAtribuidasAMim.Size = new System.Drawing.Size(85, 13);
            this.lblNotificacoesAtribuidasAMim.TabIndex = 12;
            this.lblNotificacoesAtribuidasAMim.Text = "Atribuídas a mim";
            this.lblNotificacoesAtribuidasAMim.Click += new System.EventHandler(this.lblNotificacoesAtribuidasAMim_Click);
            // 
            // txtPesquisarNotificacoes
            // 
            this.txtPesquisarNotificacoes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPesquisarNotificacoes.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisarNotificacoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPesquisarNotificacoes.Location = new System.Drawing.Point(64, 98);
            this.txtPesquisarNotificacoes.Name = "txtPesquisarNotificacoes";
            this.txtPesquisarNotificacoes.Size = new System.Drawing.Size(254, 27);
            this.txtPesquisarNotificacoes.TabIndex = 32;
            this.txtPesquisarNotificacoes.Text = "Pesquisar em todas as notificações";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(374, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 22);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Apenas não lidas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::structa_front.Properties.Resources.IconePesquisar__2_;
            this.pictureBox2.Location = new System.Drawing.Point(24, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::structa_front.Properties.Resources.LineSeparator;
            this.pictureBox6.Location = new System.Drawing.Point(24, 91);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(489, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblNotificacoesComMencao
            // 
            this.lblNotificacoesComMencao.AutoSize = true;
            this.lblNotificacoesComMencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotificacoesComMencao.ForeColor = System.Drawing.Color.White;
            this.lblNotificacoesComMencao.Location = new System.Drawing.Point(115, 72);
            this.lblNotificacoesComMencao.Name = "lblNotificacoesComMencao";
            this.lblNotificacoesComMencao.Size = new System.Drawing.Size(69, 13);
            this.lblNotificacoesComMencao.TabIndex = 35;
            this.lblNotificacoesComMencao.Text = "Com menção";
            this.lblNotificacoesComMencao.Click += new System.EventHandler(this.lblNotificacoesComMencao_Click);
            // 
            // Notificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(549, 788);
            this.Controls.Add(this.lblNotificacoesComMencao);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPesquisarNotificacoes);
            this.Controls.Add(this.lblNotificacoesAtribuidasAMim);
            this.Controls.Add(this.lblNotificacoesTodas);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Name = "Notificacoes";
            this.Text = "Notificacoes";
            this.Load += new System.EventHandler(this.Notificacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblNotificacoesTodas;
        private System.Windows.Forms.Label lblNotificacoesAtribuidasAMimlblNotificacoesComMencao;
        private System.Windows.Forms.Label lblNotificacoesAtribuidasAMim;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPesquisarNotificacoes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblNotificacoesComMencao;
    }
}