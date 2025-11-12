namespace structa_front
{
    partial class AdicionarMembros
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
            txtPesquisarNotificacoes = new TextBox();
            lblNotificacoesTodas = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPesquisarNotificacoes
            // 
            txtPesquisarNotificacoes.Font = new Font("Segoe UI", 11F);
            txtPesquisarNotificacoes.ForeColor = Color.Gray;
            txtPesquisarNotificacoes.ImeMode = ImeMode.NoControl;
            txtPesquisarNotificacoes.Location = new Point(28, 105);
            txtPesquisarNotificacoes.Margin = new Padding(4, 3, 4, 3);
            txtPesquisarNotificacoes.Name = "txtPesquisarNotificacoes";
            txtPesquisarNotificacoes.Size = new Size(345, 27);
            txtPesquisarNotificacoes.TabIndex = 35;
            txtPesquisarNotificacoes.Text = "exemplo@email.com";
            // 
            // lblNotificacoesTodas
            // 
            lblNotificacoesTodas.AutoSize = true;
            lblNotificacoesTodas.Cursor = Cursors.Hand;
            lblNotificacoesTodas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotificacoesTodas.ForeColor = Color.White;
            lblNotificacoesTodas.Location = new Point(24, 87);
            lblNotificacoesTodas.Margin = new Padding(4, 0, 4, 0);
            lblNotificacoesTodas.Name = "lblNotificacoesTodas";
            lblNotificacoesTodas.Size = new Size(116, 13);
            lblNotificacoesTodas.TabIndex = 34;
            lblNotificacoesTodas.Text = "Convidar por e-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 24);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(13, 0, 0, 0);
            label1.Size = new Size(492, 31);
            label1.TabIndex = 33;
            label1.Text = "Adicione colaboradores no seu Structa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 11F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(28, 143);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 22);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "Membro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 11F);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(132, 143);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(68, 22);
            checkBox2.TabIndex = 37;
            checkBox2.Text = "Admin";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 11F);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(218, 143);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(150, 22);
            checkBox3.TabIndex = 38;
            checkBox3.Text = "Gerente de projeto";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 13);
            label2.TabIndex = 39;
            label2.Text = "Escreva uma mensagem (opicional)";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(28, 203);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 92);
            textBox2.TabIndex = 41;
            textBox2.Text = "Adicione um contexto para novos membros";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(28, 301);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 42;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdicionarMembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 20, 47);
            ClientSize = new Size(836, 370);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtPesquisarNotificacoes);
            Controls.Add(lblNotificacoesTodas);
            Controls.Add(label1);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdicionarMembros";
            Text = "ConvidarMembros";
            Load += AdicionarMembros_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisarNotificacoes;
        private System.Windows.Forms.Label lblNotificacoesTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}