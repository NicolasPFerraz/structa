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
            txtEmail = new TextBox();
            lblEmail = new Label();
            label1 = new Label();
            lblProjeto = new Label();
            btnAdicionar = new Button();
            comboFuncao = new ComboBox();
            lblFuncao = new Label();
            comboProjetos = new ComboBox();
            listMembros = new ListBox();
            lblListMembros = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(28, 105);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "exemplo@email.com";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Cursor = Cursors.Hand;
            lblEmail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(28, 89);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 13);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Convidar por e-mail";
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
            // lblProjeto
            // 
            lblProjeto.AutoSize = true;
            lblProjeto.Cursor = Cursors.Hand;
            lblProjeto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProjeto.ForeColor = Color.White;
            lblProjeto.Location = new Point(28, 201);
            lblProjeto.Margin = new Padding(4, 0, 4, 0);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(121, 13);
            lblProjeto.TabIndex = 39;
            lblProjeto.Text = "Selecione o projeto:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(28, 327);
            btnAdicionar.Margin = new Padding(2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 32);
            btnAdicionar.TabIndex = 42;
            btnAdicionar.Text = "Adicionar ao projeto";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // comboFuncao
            // 
            comboFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Location = new Point(28, 159);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(225, 23);
            comboFuncao.TabIndex = 43;
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Cursor = Cursors.Hand;
            lblFuncao.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncao.ForeColor = Color.White;
            lblFuncao.Location = new Point(28, 143);
            lblFuncao.Margin = new Padding(4, 0, 4, 0);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(53, 13);
            lblFuncao.TabIndex = 44;
            lblFuncao.Text = "Função:";
            // 
            // comboProjetos
            // 
            comboProjetos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProjetos.FormattingEnabled = true;
            comboProjetos.Location = new Point(29, 217);
            comboProjetos.Name = "comboProjetos";
            comboProjetos.Size = new Size(224, 23);
            comboProjetos.TabIndex = 45;
            // 
            // listMembros
            // 
            listMembros.FormattingEnabled = true;
            listMembros.ItemHeight = 15;
            listMembros.Location = new Point(323, 105);
            listMembros.Name = "listMembros";
            listMembros.Size = new Size(293, 94);
            listMembros.TabIndex = 46;
            listMembros.SelectedIndexChanged += comboProjetos_SelectedIndexChanged;
            // 
            // lblListMembros
            // 
            lblListMembros.AutoSize = true;
            lblListMembros.Cursor = Cursors.Hand;
            lblListMembros.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListMembros.ForeColor = Color.White;
            lblListMembros.Location = new Point(323, 89);
            lblListMembros.Margin = new Padding(4, 0, 4, 0);
            lblListMembros.Name = "lblListMembros";
            lblListMembros.Size = new Size(136, 13);
            lblListMembros.TabIndex = 47;
            lblListMembros.Text = "Membros já no projeto:";
            // 
            // AdicionarMembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 20, 47);
            ClientSize = new Size(836, 370);
            Controls.Add(lblListMembros);
            Controls.Add(listMembros);
            Controls.Add(comboProjetos);
            Controls.Add(lblFuncao);
            Controls.Add(comboFuncao);
            Controls.Add(btnAdicionar);
            Controls.Add(lblProjeto);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
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

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.Button btnAdicionar;
        private ComboBox comboFuncao;
        private Label lblFuncao;
        private ComboBox comboProjetos;
        private ListBox listMembros;
        private Label lblListMembros;
    }
}