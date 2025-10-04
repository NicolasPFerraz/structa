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
            this.roundedPanel = new structa_front.RoundedPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginDesc = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel
            // 
            this.roundedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.roundedPanel.Controls.Add(this.pictureBox1);
            this.roundedPanel.Controls.Add(this.label1);
            this.roundedPanel.Controls.Add(this.lblWelcome);
            this.roundedPanel.Controls.Add(this.lblLoginTitle);
            this.roundedPanel.Controls.Add(this.lblLoginDesc);
            this.roundedPanel.Controls.Add(this.lblUser);
            this.roundedPanel.Controls.Add(this.txtUser);
            this.roundedPanel.Controls.Add(this.lblPassword);
            this.roundedPanel.Controls.Add(this.txtPassword);
            this.roundedPanel.Controls.Add(this.chkRemember);
            this.roundedPanel.Controls.Add(this.lblForgotPassword);
            this.roundedPanel.Controls.Add(this.btnLogin);
            this.roundedPanel.Controls.Add(this.lblRegister);
            this.roundedPanel.CornerRadius = 10;
            this.roundedPanel.Location = new System.Drawing.Point(459, 80);
            this.roundedPanel.Name = "roundedPanel";
            this.roundedPanel.ShadowColor = System.Drawing.Color.White;
            this.roundedPanel.ShadowOffset = 16;
            this.roundedPanel.Size = new System.Drawing.Size(505, 701);
            this.roundedPanel.TabIndex = 0;
            this.roundedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(40, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem vindo !";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLoginTitle.Location = new System.Drawing.Point(40, 106);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(400, 45);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Login";
            this.lblLoginTitle.Click += new System.EventHandler(this.lblLoginTitle_Click);
            // 
            // lblLoginDesc
            // 
            this.lblLoginDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLoginDesc.ForeColor = System.Drawing.Color.Black;
            this.lblLoginDesc.Location = new System.Drawing.Point(40, 156);
            this.lblLoginDesc.Name = "lblLoginDesc";
            this.lblLoginDesc.Size = new System.Drawing.Size(400, 30);
            this.lblLoginDesc.TabIndex = 2;
            this.lblLoginDesc.Text = "Digite os dados para realizar o login";
            this.lblLoginDesc.Click += new System.EventHandler(this.lblLoginDesc_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(40, 206);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(400, 25);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario/E-mail";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(40, 236);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(423, 27);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "Digite seu nome ou e-mail";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(40, 286);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(400, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(40, 316);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(371, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Digite sua senha";
            // 
            // chkRemember
            // 
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkRemember.ForeColor = System.Drawing.Color.Black;
            this.chkRemember.Location = new System.Drawing.Point(40, 366);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(120, 25);
            this.chkRemember.TabIndex = 8;
            this.chkRemember.Text = "lembrar-me";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblForgotPassword.Location = new System.Drawing.Point(270, 366);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(170, 25);
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
            this.btnLogin.Location = new System.Drawing.Point(40, 416);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(423, 45);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRegister.ForeColor = System.Drawing.Color.Gray;
            this.lblRegister.Location = new System.Drawing.Point(43, 508);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(327, 30);
            this.lblRegister.TabIndex = 11;
            this.lblRegister.Text = "Não possui uma conta ainda?";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registre-se";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::structa_front.Properties.Resources.eye;
            this.pictureBox1.Location = new System.Drawing.Point(416, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.roundedPanel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.roundedPanel.ResumeLayout(false);
            this.roundedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

