namespace structa_front
{
    partial class CriarConta
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
            roundedPanel = new RoundedPanel();
            pictureBox2 = new PictureBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblBemVindo = new Label();
            lblLoginTitulo = new Label();
            lblLoginDesc = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenhaConfirmar = new Label();
            txtSenhaConfirmada = new TextBox();
            btnRegistrar = new Button();
            lblRegister = new Label();
            roundedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel
            // 
            roundedPanel.BackColor = Color.White;
            roundedPanel.Controls.Add(pictureBox2);
            roundedPanel.Controls.Add(lblSenha);
            roundedPanel.Controls.Add(txtSenha);
            roundedPanel.Controls.Add(lblNomeUsuario);
            roundedPanel.Controls.Add(txtNomeUsuario);
            roundedPanel.Controls.Add(pictureBox1);
            roundedPanel.Controls.Add(lblLogin);
            roundedPanel.Controls.Add(lblBemVindo);
            roundedPanel.Controls.Add(lblLoginTitulo);
            roundedPanel.Controls.Add(lblLoginDesc);
            roundedPanel.Controls.Add(lblEmail);
            roundedPanel.Controls.Add(txtEmail);
            roundedPanel.Controls.Add(lblSenhaConfirmar);
            roundedPanel.Controls.Add(txtSenhaConfirmada);
            roundedPanel.Controls.Add(btnRegistrar);
            roundedPanel.Controls.Add(lblRegister);
            roundedPanel.CornerRadius = 10;
            roundedPanel.Location = new Point(538, 98);
            roundedPanel.Margin = new Padding(4, 3, 4, 3);
            roundedPanel.Name = "roundedPanel";
            roundedPanel.ShadowColor = Color.White;
            roundedPanel.ShadowOffset = 16;
            roundedPanel.Size = new Size(589, 804);
            roundedPanel.TabIndex = 1;
            roundedPanel.Paint += roundedPanel_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.eye;
            pictureBox2.Location = new Point(490, 471);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSenha.ForeColor = Color.Black;
            lblSenha.Location = new Point(50, 436);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(467, 29);
            lblSenha.TabIndex = 16;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.ForeColor = Color.Gray;
            txtSenha.ImeMode = ImeMode.NoControl;
            txtSenha.Location = new Point(50, 471);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(432, 27);
            txtSenha.TabIndex = 17;
            txtSenha.Text = "Crie uma senha forte";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNomeUsuario.ForeColor = Color.Black;
            lblNomeUsuario.Location = new Point(50, 336);
            lblNomeUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(467, 29);
            lblNomeUsuario.TabIndex = 14;
            lblNomeUsuario.Text = "Nome de usuário";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 11F);
            txtNomeUsuario.ForeColor = Color.Gray;
            txtNomeUsuario.Location = new Point(50, 370);
            txtNomeUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(493, 27);
            txtNomeUsuario.TabIndex = 15;
            txtNomeUsuario.Text = "Crie um nome de usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(490, 576);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(323, 721);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 35);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin.Click += lblLogin_Click;
            lblLogin.MouseEnter += lblLogin_MouseEnter;
            lblLogin.MouseLeave += lblLogin_MouseLeave;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.Black;
            lblBemVindo.Location = new Point(47, 65);
            lblBemVindo.Margin = new Padding(4, 0, 4, 0);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(467, 46);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem vindo !";
            lblBemVindo.Click += lblWelcome_Click;
            // 
            // lblLoginTitulo
            // 
            lblLoginTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitulo.ForeColor = Color.Black;
            lblLoginTitulo.Location = new Point(47, 122);
            lblLoginTitulo.Margin = new Padding(4, 0, 4, 0);
            lblLoginTitulo.Name = "lblLoginTitulo";
            lblLoginTitulo.Size = new Size(467, 52);
            lblLoginTitulo.TabIndex = 1;
            lblLoginTitulo.Text = "Crie sua conta";
            // 
            // lblLoginDesc
            // 
            lblLoginDesc.Font = new Font("Segoe UI", 12F);
            lblLoginDesc.ForeColor = Color.Black;
            lblLoginDesc.Location = new Point(47, 180);
            lblLoginDesc.Margin = new Padding(4, 0, 4, 0);
            lblLoginDesc.Name = "lblLoginDesc";
            lblLoginDesc.Size = new Size(467, 35);
            lblLoginDesc.TabIndex = 2;
            lblLoginDesc.Text = "Insira seus dados para criar sua conta";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(47, 238);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(467, 29);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblUser_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(47, 272);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(493, 27);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Digite seu nome ou e-mail";
            txtEmail.TextChanged += txtUser_TextChanged;
            // 
            // lblSenhaConfirmar
            // 
            lblSenhaConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSenhaConfirmar.ForeColor = Color.Black;
            lblSenhaConfirmar.Location = new Point(51, 541);
            lblSenhaConfirmar.Margin = new Padding(4, 0, 4, 0);
            lblSenhaConfirmar.Name = "lblSenhaConfirmar";
            lblSenhaConfirmar.Size = new Size(467, 29);
            lblSenhaConfirmar.TabIndex = 5;
            lblSenhaConfirmar.Text = "Confirme sua senha";
            // 
            // txtSenhaConfirmada
            // 
            txtSenhaConfirmada.Font = new Font("Segoe UI", 11F);
            txtSenhaConfirmada.ForeColor = Color.Gray;
            txtSenhaConfirmada.ImeMode = ImeMode.NoControl;
            txtSenhaConfirmada.Location = new Point(51, 576);
            txtSenhaConfirmada.Margin = new Padding(4, 3, 4, 3);
            txtSenhaConfirmada.Name = "txtSenhaConfirmada";
            txtSenhaConfirmada.Size = new Size(432, 27);
            txtSenhaConfirmada.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(50, 643);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(493, 52);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblRegister
            // 
            lblRegister.Font = new Font("Segoe UI", 12F);
            lblRegister.ForeColor = Color.Gray;
            lblRegister.Location = new Point(190, 721);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(140, 35);
            lblRegister.TabIndex = 11;
            lblRegister.Text = "Já tem uma conta?";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(4, 12, 40);
            ClientSize = new Size(1370, 749);
            Controls.Add(roundedPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CriarConta";
            Text = "CriarConta";
            Load += CriarConta_Load;
            roundedPanel.ResumeLayout(false);
            roundedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.Label lblLoginDesc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenhaConfirmar;
        private System.Windows.Forms.TextBox txtSenhaConfirmada;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}