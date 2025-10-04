namespace structa_front
{
    partial class Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel = new structa_front.RoundedPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginDesc = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.roundedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel
            // 
            this.roundedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.roundedPanel.Controls.Add(this.lblWelcome);
            this.roundedPanel.Controls.Add(this.lblLoginTitle);
            this.roundedPanel.Controls.Add(this.lblLoginDesc);
            this.roundedPanel.Controls.Add(this.lblUser);
            this.roundedPanel.Controls.Add(this.txtUser);
            this.roundedPanel.Controls.Add(this.lblPassword);
            this.roundedPanel.Controls.Add(this.txtPassword);
            this.roundedPanel.Controls.Add(this.btnTogglePassword);
            this.roundedPanel.Controls.Add(this.chkRemember);
            this.roundedPanel.Controls.Add(this.lblForgotPassword);
            this.roundedPanel.Controls.Add(this.btnLogin);
            this.roundedPanel.Controls.Add(this.lblRegister);
            this.roundedPanel.CornerRadius = 10;
            this.roundedPanel.Location = new System.Drawing.Point(612, 98);
            this.roundedPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.ShadowColor = System.Drawing.Color.White;
            this.roundedPanel.ShadowOffset = 16;
            this.roundedPanel.Size = new System.Drawing.Size(673, 863);
            this.roundedPanel.TabIndex = 0;
            this.roundedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(53, 37);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(533, 49);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem vindo !";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLoginTitle.Location = new System.Drawing.Point(53, 98);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(533, 55);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Login";
            // 
            // lblLoginDesc
            // 
            this.lblLoginDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLoginDesc.ForeColor = System.Drawing.Color.Black;
            this.lblLoginDesc.Location = new System.Drawing.Point(53, 160);
            this.lblLoginDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginDesc.Name = "lblLoginDesc";
            this.lblLoginDesc.Size = new System.Drawing.Size(533, 37);
            this.lblLoginDesc.TabIndex = 2;
            this.lblLoginDesc.Text = "Digite os dados para realizar o login";
            this.lblLoginDesc.Click += new System.EventHandler(this.lblLoginDesc_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(53, 222);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(533, 31);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario/E-mail";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(53, 258);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(532, 32);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "Digite seu nome ou e-mail";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(53, 320);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(533, 31);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(53, 357);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(479, 32);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Digite sua senha";
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.BackColor = System.Drawing.Color.White;
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTogglePassword.Location = new System.Drawing.Point(533, 357);
            this.btnTogglePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(53, 33);
            this.btnTogglePassword.TabIndex = 7;
            this.btnTogglePassword.TabStop = false;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.UseVisualStyleBackColor = false;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkRemember.ForeColor = System.Drawing.Color.Black;
            this.chkRemember.Location = new System.Drawing.Point(53, 418);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(160, 31);
            this.chkRemember.TabIndex = 8;
            this.chkRemember.Text = "lembrar-me";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblForgotPassword.Location = new System.Drawing.Point(360, 418);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(227, 31);
            this.lblForgotPassword.TabIndex = 9;
            this.lblForgotPassword.Text = "Esqueceu sua senha ?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(53, 480);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(533, 55);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRegister.ForeColor = System.Drawing.Color.Gray;
            this.lblRegister.Location = new System.Drawing.Point(53, 566);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(533, 37);
            this.lblRegister.TabIndex = 11;
            this.lblRegister.Text = "Não possui uma conta ainda? Registre-se";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1899, 1055);
            this.Controls.Add(this.roundedPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1914, 1018);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.roundedPanel.ResumeLayout(false);
            this.roundedPanel.PerformLayout();
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
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
    }
}

