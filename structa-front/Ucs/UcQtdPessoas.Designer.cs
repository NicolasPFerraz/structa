namespace structa_front
{
    partial class UcQtdPessoas
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
            panelQtdPessoas = new Panel();
            btnAvancar = new Button();
            BTN_Equipe_G = new Button();
            BTN_Equipe_P = new Button();
            BTN_Solo = new Button();
            label1 = new Label();
            panelQtdPessoas.SuspendLayout();
            SuspendLayout();
            // 
            // panelQtdPessoas
            // 
            panelQtdPessoas.Controls.Add(btnAvancar);
            panelQtdPessoas.Controls.Add(BTN_Equipe_G);
            panelQtdPessoas.Controls.Add(BTN_Equipe_P);
            panelQtdPessoas.Controls.Add(BTN_Solo);
            panelQtdPessoas.Controls.Add(label1);
            panelQtdPessoas.Dock = DockStyle.Fill;
            panelQtdPessoas.Location = new Point(0, 0);
            panelQtdPessoas.Margin = new Padding(4);
            panelQtdPessoas.Name = "panelQtdPessoas";
            panelQtdPessoas.Size = new Size(1680, 609);
            panelQtdPessoas.TabIndex = 17;
            panelQtdPessoas.Paint += panelQtdPessoas_Paint;
            // 
            // btnAvancar
            // 
            btnAvancar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancar.Location = new Point(447, 183);
            btnAvancar.Margin = new Padding(3, 2, 3, 2);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(116, 32);
            btnAvancar.TabIndex = 19;
            btnAvancar.Text = "Avançar";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Visible = false;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // BTN_Equipe_G
            // 
            BTN_Equipe_G.Location = new Point(416, 85);
            BTN_Equipe_G.Margin = new Padding(3, 2, 3, 2);
            BTN_Equipe_G.Name = "BTN_Equipe_G";
            BTN_Equipe_G.Size = new Size(116, 32);
            BTN_Equipe_G.TabIndex = 18;
            BTN_Equipe_G.Text = "15-500";
            BTN_Equipe_G.UseVisualStyleBackColor = true;
            BTN_Equipe_G.Click += BTN_Equipe_G_Click;
            // 
            // BTN_Equipe_P
            // 
            BTN_Equipe_P.Location = new Point(231, 85);
            BTN_Equipe_P.Margin = new Padding(3, 2, 3, 2);
            BTN_Equipe_P.Name = "BTN_Equipe_P";
            BTN_Equipe_P.Size = new Size(116, 32);
            BTN_Equipe_P.TabIndex = 17;
            BTN_Equipe_P.Text = "1-15";
            BTN_Equipe_P.UseVisualStyleBackColor = true;
            BTN_Equipe_P.Click += BTN_Equipe_P_Click;
            // 
            // BTN_Solo
            // 
            BTN_Solo.Location = new Point(35, 85);
            BTN_Solo.Margin = new Padding(3, 2, 3, 2);
            BTN_Solo.Name = "BTN_Solo";
            BTN_Solo.Size = new Size(116, 32);
            BTN_Solo.TabIndex = 16;
            BTN_Solo.Text = "Apenas eu";
            BTN_Solo.UseVisualStyleBackColor = true;
            BTN_Solo.Click += BTN_Solo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(488, 41);
            label1.TabIndex = 15;
            label1.Text = "Quantas pessoas há na sua equipe?";
            // 
            // UcQtdPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelQtdPessoas);
            Margin = new Padding(4);
            Name = "UcQtdPessoas";
            Size = new Size(1680, 609);
            panelQtdPessoas.ResumeLayout(false);
            panelQtdPessoas.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQtdPessoas;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button BTN_Equipe_G;
        private System.Windows.Forms.Button BTN_Equipe_P;
        private System.Windows.Forms.Button BTN_Solo;
        private System.Windows.Forms.Label label1;
    }
}
