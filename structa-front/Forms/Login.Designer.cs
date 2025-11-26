using structa_front.Forms;

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
            roundedPanel1 = new RoundedPanel();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblRegistrar = new Label();
            lblBemVindo = new Label();
            lblLoginTitulo = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(checkBox1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(lblSenha);
            roundedPanel1.Controls.Add(txtSenha);
            roundedPanel1.Controls.Add(lblRegistrar);
            roundedPanel1.Controls.Add(lblBemVindo);
            roundedPanel1.Controls.Add(lblLoginTitulo);
            roundedPanel1.Controls.Add(lblEmail);
            roundedPanel1.Controls.Add(txtEmail);
            roundedPanel1.Controls.Add(btnLogin);
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.Location = new Point(461, 85);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.ShadowColor = Color.FromArgb(60, 0, 0, 0);
            roundedPanel1.ShadowOffset = 16;
            roundedPanel1.Size = new Size(505, 622);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(321, 374);
            label2.Name = "label2";
            label2.Size = new Size(141, 30);
            label2.TabIndex = 34;
            label2.Text = "Esqueceu sua senha?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox1.Location = new Point(46, 383);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 21);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Lembrar-me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(88, 516);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 32;
            label1.Text = "Ainda não possui uma conta?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.eye;
            pictureBox2.Location = new Point(419, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSenha.ForeColor = Color.Black;
            lblSenha.Location = new Point(42, 294);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(400, 25);
            lblSenha.TabIndex = 29;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.ForeColor = Color.Gray;
            txtSenha.ImeMode = ImeMode.NoControl;
            txtSenha.Location = new Point(42, 324);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(371, 27);
            txtSenha.TabIndex = 30;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblRegistrar
            // 
            lblRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.Black;
            lblRegistrar.Location = new Point(286, 516);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(127, 30);
            lblRegistrar.TabIndex = 26;
            lblRegistrar.Text = "Registre-se";
            lblRegistrar.TextAlign = ContentAlignment.MiddleCenter;
            lblRegistrar.Click += lblRegistrar_Click;
            lblRegistrar.MouseEnter += lblRegistrar_MouseEnter;
            lblRegistrar.MouseLeave += lblRegistrar_MouseLeave;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.Black;
            lblBemVindo.Location = new Point(39, 49);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(400, 40);
            lblBemVindo.TabIndex = 19;
            lblBemVindo.Text = "Bem vindo !";
            lblBemVindo.Click += lblBemVindo_Click;
            // 
            // lblLoginTitulo
            // 
            lblLoginTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitulo.ForeColor = Color.Black;
            lblLoginTitulo.Location = new Point(39, 99);
            lblLoginTitulo.Name = "lblLoginTitulo";
            lblLoginTitulo.Size = new Size(400, 59);
            lblLoginTitulo.TabIndex = 20;
            lblLoginTitulo.Text = "Login";
            lblLoginTitulo.Click += lblLoginTitulo_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(39, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(400, 25);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(39, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(423, 27);
            txtEmail.TabIndex = 22;
            txtEmail.Text = "Digite seu nome ou e-mail";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(39, 430);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(423, 45);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            BackColor = Color.FromArgb(4, 12, 40);
            ClientSize = new Size(1424, 861);
            Controls.Add(roundedPanel1);
            Name = "Login";
            Load += Login_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel;
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

