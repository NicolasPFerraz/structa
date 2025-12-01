namespace structa_front
{
    partial class StatusTrabalho
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
            RD_Escritorio = new RadioButton();
            RD_Ausente = new RadioButton();
            RD_TrabalhoCasa = new RadioButton();
            RD_LicençaMedica = new RadioButton();
            RD_TrabalhoExterno = new RadioButton();
            RD_Ferias = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 0;
            label1.Text = "Status do trabalho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(250, 24);
            label2.TabIndex = 1;
            label2.Text = "Deixe todos saber seu status";
            // 
            // RD_Escritorio
            // 
            RD_Escritorio.AutoSize = true;
            RD_Escritorio.ForeColor = Color.White;
            RD_Escritorio.Location = new Point(27, 143);
            RD_Escritorio.Name = "RD_Escritorio";
            RD_Escritorio.Size = new Size(93, 19);
            RD_Escritorio.TabIndex = 2;
            RD_Escritorio.TabStop = true;
            RD_Escritorio.Text = "No escritorio";
            RD_Escritorio.UseVisualStyleBackColor = true;
            // 
            // RD_Ausente
            // 
            RD_Ausente.AutoSize = true;
            RD_Ausente.ForeColor = Color.White;
            RD_Ausente.Location = new Point(134, 143);
            RD_Ausente.Name = "RD_Ausente";
            RD_Ausente.Size = new Size(68, 19);
            RD_Ausente.TabIndex = 3;
            RD_Ausente.TabStop = true;
            RD_Ausente.Text = "Ausente";
            RD_Ausente.UseVisualStyleBackColor = true;
            // 
            // RD_TrabalhoCasa
            // 
            RD_TrabalhoCasa.AutoSize = true;
            RD_TrabalhoCasa.ForeColor = Color.White;
            RD_TrabalhoCasa.Location = new Point(226, 143);
            RD_TrabalhoCasa.Name = "RD_TrabalhoCasa";
            RD_TrabalhoCasa.Size = new Size(133, 19);
            RD_TrabalhoCasa.TabIndex = 4;
            RD_TrabalhoCasa.TabStop = true;
            RD_TrabalhoCasa.Text = "Trabalhando de casa";
            RD_TrabalhoCasa.UseVisualStyleBackColor = true;
            // 
            // RD_LicençaMedica
            // 
            RD_LicençaMedica.AutoSize = true;
            RD_LicençaMedica.ForeColor = Color.White;
            RD_LicençaMedica.Location = new Point(385, 143);
            RD_LicençaMedica.Name = "RD_LicençaMedica";
            RD_LicençaMedica.Size = new Size(107, 19);
            RD_LicençaMedica.TabIndex = 5;
            RD_LicençaMedica.TabStop = true;
            RD_LicençaMedica.Text = "Licença Médica";
            RD_LicençaMedica.UseVisualStyleBackColor = true;
            // 
            // RD_TrabalhoExterno
            // 
            RD_TrabalhoExterno.AutoSize = true;
            RD_TrabalhoExterno.ForeColor = Color.White;
            RD_TrabalhoExterno.Location = new Point(503, 143);
            RD_TrabalhoExterno.Name = "RD_TrabalhoExterno";
            RD_TrabalhoExterno.Size = new Size(166, 19);
            RD_TrabalhoExterno.TabIndex = 6;
            RD_TrabalhoExterno.TabStop = true;
            RD_TrabalhoExterno.Text = "Trabalhando externamente";
            RD_TrabalhoExterno.UseVisualStyleBackColor = true;
            // 
            // RD_Ferias
            // 
            RD_Ferias.AutoSize = true;
            RD_Ferias.ForeColor = Color.White;
            RD_Ferias.Location = new Point(690, 143);
            RD_Ferias.Name = "RD_Ferias";
            RD_Ferias.Size = new Size(55, 19);
            RD_Ferias.TabIndex = 7;
            RD_Ferias.TabStop = true;
            RD_Ferias.Text = "Férias";
            RD_Ferias.UseVisualStyleBackColor = true;
            // 
            // StatusTrabalho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 30, 76);
            Controls.Add(RD_Ferias);
            Controls.Add(RD_TrabalhoExterno);
            Controls.Add(RD_LicençaMedica);
            Controls.Add(RD_TrabalhoCasa);
            Controls.Add(RD_Ausente);
            Controls.Add(RD_Escritorio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StatusTrabalho";
            Size = new Size(1037, 676);
            Load += StatusTrabalho_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RD_Escritorio;
        private System.Windows.Forms.RadioButton RD_Ausente;
        private System.Windows.Forms.RadioButton RD_TrabalhoCasa;
        private System.Windows.Forms.RadioButton RD_LicençaMedica;
        private System.Windows.Forms.RadioButton RD_TrabalhoExterno;
        private System.Windows.Forms.RadioButton RD_Ferias;
    }
}