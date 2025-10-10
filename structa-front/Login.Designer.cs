namespace structa_front
{
    partial class Login : BaseForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new structa_front.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.checkBox1);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.pictureBox2);
            this.roundedPanel1.Controls.Add(this.lblSenha);
            this.roundedPanel1.Controls.Add(this.txtSenha);
            this.roundedPanel1.Controls.Add(this.lblRegistrar);
            this.roundedPanel1.Controls.Add(this.lblBemVindo);
            this.roundedPanel1.Controls.Add(this.lblLoginTitulo);
            this.roundedPanel1.Controls.Add(this.lblEmail);
            this.roundedPanel1.Controls.Add(this.txtEmail);
            this.roundedPanel1.Controls.Add(this.btnLogin);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(461, 85);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundedPanel1.ShadowOffset = 16;
            this.roundedPanel1.Size = new System.Drawing.Size(505, 622);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(321, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Esqueceu sua senha?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(46, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 21);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Lembrar-me";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(88, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ainda não possui uma conta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::structa_front.Properties.Resources.eye;
            this.pictureBox2.Location = new System.Drawing.Point(419, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(42, 294);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(400, 25);
            this.lblSenha.TabIndex = 29;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSenha.Location = new System.Drawing.Point(42, 324);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(371, 27);
            this.txtSenha.TabIndex = 30;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrar.Location = new System.Drawing.Point(286, 516);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(127, 30);
            this.lblRegistrar.TabIndex = 26;
            this.lblRegistrar.Text = "Registre-se";
            this.lblRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegistrar.Click += new System.EventHandler(this.lblRegistrar_Click);
            this.lblRegistrar.MouseEnter += new System.EventHandler(this.lblRegistrar_MouseEnter);
            this.lblRegistrar.MouseLeave += new System.EventHandler(this.lblRegistrar_MouseLeave);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo.Location = new System.Drawing.Point(39, 49);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(400, 40);
            this.lblBemVindo.TabIndex = 19;
            this.lblBemVindo.Text = "Bem vindo !";
            this.lblBemVindo.Click += new System.EventHandler(this.lblBemVindo_Click);
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblLoginTitulo.Location = new System.Drawing.Point(39, 99);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(400, 59);
            this.lblLoginTitulo.TabIndex = 20;
            this.lblLoginTitulo.Text = "Login";
            this.lblLoginTitulo.Click += new System.EventHandler(this.lblLoginTitulo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(39, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(400, 25);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "E-mail/Nome de usuário";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(39, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(423, 27);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "Digite seu nome ou e-mail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(39, 430);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(423, 45);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private structa_front.RoundedPanel roundedPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginDesc;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblRegistreSe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

