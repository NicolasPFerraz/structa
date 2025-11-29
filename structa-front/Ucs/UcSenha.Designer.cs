namespace structa_front
{
    partial class Senha
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSenhaAtual = new TextBox();
            txtNovaSenha = new TextBox();
            txtNovaSenhaConfirmada = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 39);
            label1.TabIndex = 0;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 99);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Senha atual";
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(62, 131);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(299, 23);
            txtSenhaAtual.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(62, 251);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(299, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // txtNovaSenhaConfirmada
            // 
            txtNovaSenhaConfirmada.Location = new Point(62, 337);
            txtNovaSenhaConfirmada.Name = "txtNovaSenhaConfirmada";
            txtNovaSenhaConfirmada.Size = new Size(303, 23);
            txtNovaSenhaConfirmada.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 157);
            label3.Name = "label3";
            label3.Size = new Size(113, 13);
            label3.TabIndex = 5;
            label3.Text = "Esqueceu sua senha?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 219);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "Nova Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(58, 298);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 8;
            label5.Text = "Confirme a nova senha";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(62, 376);
            button1.Name = "button1";
            button1.Size = new Size(225, 37);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(62, 179);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 13);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Redefinir senha via E-mail";
            // 
            // Senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 76);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(txtNovaSenhaConfirmada);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtSenhaAtual);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Senha";
            Size = new Size(1037, 676);
            Load += Senha_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenhaConfirmada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private LinkLabel linkLabel1;
    }
}