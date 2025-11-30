namespace structa_front.Forms
{
    partial class NovoProjeto
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
            LBL_CriarNovoProjeto = new Label();
            pictureBox6 = new PictureBox();
            btn_criar = new Button();
            txt_nomeprojeto = new TextBox();
            txt_descricao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // LBL_CriarNovoProjeto
            // 
            LBL_CriarNovoProjeto.AutoSize = true;
            LBL_CriarNovoProjeto.ForeColor = SystemColors.Control;
            LBL_CriarNovoProjeto.Location = new Point(21, 24);
            LBL_CriarNovoProjeto.Margin = new Padding(12, 0, 12, 0);
            LBL_CriarNovoProjeto.Name = "LBL_CriarNovoProjeto";
            LBL_CriarNovoProjeto.Size = new Size(527, 81);
            LBL_CriarNovoProjeto.TabIndex = 0;
            LBL_CriarNovoProjeto.Text = "Criar Novo Projeto";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.LineSeparator;
            pictureBox6.Location = new Point(33, 130);
            pictureBox6.Margin = new Padding(5, 4, 5, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(651, 1);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // btn_criar
            // 
            btn_criar.BackColor = Color.Black;
            btn_criar.FlatStyle = FlatStyle.Flat;
            btn_criar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criar.ForeColor = Color.White;
            btn_criar.Location = new Point(240, 372);
            btn_criar.Margin = new Padding(5, 4, 5, 4);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(194, 41);
            btn_criar.TabIndex = 45;
            btn_criar.Text = "Criar";
            btn_criar.UseVisualStyleBackColor = false;
            btn_criar.Click += button1_Click;
            // 
            // txt_nomeprojeto
            // 
            txt_nomeprojeto.Font = new Font("Segoe UI", 11F);
            txt_nomeprojeto.ForeColor = Color.Gray;
            txt_nomeprojeto.ImeMode = ImeMode.NoControl;
            txt_nomeprojeto.Location = new Point(33, 158);
            txt_nomeprojeto.Margin = new Padding(5, 4, 5, 4);
            txt_nomeprojeto.Name = "txt_nomeprojeto";
            txt_nomeprojeto.Size = new Size(651, 32);
            txt_nomeprojeto.TabIndex = 44;
            txt_nomeprojeto.Text = "Nome";
            txt_nomeprojeto.TextChanged += txt_nomeprojeto_TextChanged;
            // 
            // txt_descricao
            // 
            txt_descricao.Font = new Font("Segoe UI", 11F);
            txt_descricao.ForeColor = Color.Gray;
            txt_descricao.ImeMode = ImeMode.NoControl;
            txt_descricao.Location = new Point(33, 207);
            txt_descricao.Margin = new Padding(5, 4, 5, 4);
            txt_descricao.Multiline = true;
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(651, 105);
            txt_descricao.TabIndex = 46;
            txt_descricao.Text = "Descrição";
            txt_descricao.TextChanged += textBox2_TextChanged;
            // 
            // NovoProjeto
            // 
            AutoScaleDimensions = new SizeF(33F, 81F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 20, 47);
            ClientSize = new Size(737, 692);
            Controls.Add(txt_descricao);
            Controls.Add(btn_criar);
            Controls.Add(txt_nomeprojeto);
            Controls.Add(pictureBox6);
            Controls.Add(LBL_CriarNovoProjeto);
            Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(12);
            Name = "NovoProjeto";
            Text = "NovoProjeto";
            Load += NovoProjeto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_CriarNovoProjeto;
        private PictureBox pictureBox6;
        private Button btn_criar;
        private TextBox txt_nomeprojeto;
        private TextBox txt_descricao;
    }
}