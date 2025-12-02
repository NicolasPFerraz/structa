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
            this.panelQtdPessoas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Equipe_G = new System.Windows.Forms.Button();
            this.BTN_Equipe_P = new System.Windows.Forms.Button();
            this.BTN_Solo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQtdPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQtdPessoas
            // 
            this.panelQtdPessoas.Controls.Add(this.button1);
            this.panelQtdPessoas.Controls.Add(this.BTN_Equipe_G);
            this.panelQtdPessoas.Controls.Add(this.BTN_Equipe_P);
            this.panelQtdPessoas.Controls.Add(this.BTN_Solo);
            this.panelQtdPessoas.Controls.Add(this.label1);
            this.panelQtdPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQtdPessoas.Location = new System.Drawing.Point(0, 0);
            this.panelQtdPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.panelQtdPessoas.Name = "panelQtdPessoas";
            this.panelQtdPessoas.Size = new System.Drawing.Size(1920, 650);
            this.panelQtdPessoas.TabIndex = 17;
            this.panelQtdPessoas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQtdPessoas_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Avançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // BTN_Equipe_G
            // 
            this.BTN_Equipe_G.Location = new System.Drawing.Point(578, 98);
            this.BTN_Equipe_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Equipe_G.Name = "BTN_Equipe_G";
            this.BTN_Equipe_G.Size = new System.Drawing.Size(133, 34);
            this.BTN_Equipe_G.TabIndex = 18;
            this.BTN_Equipe_G.Text = "15-500";
            this.BTN_Equipe_G.UseVisualStyleBackColor = true;
            // 
            // BTN_Equipe_P
            // 
            this.BTN_Equipe_P.Location = new System.Drawing.Point(367, 98);
            this.BTN_Equipe_P.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Equipe_P.Name = "BTN_Equipe_P";
            this.BTN_Equipe_P.Size = new System.Drawing.Size(133, 34);
            this.BTN_Equipe_P.TabIndex = 17;
            this.BTN_Equipe_P.Text = "1-15";
            this.BTN_Equipe_P.UseVisualStyleBackColor = true;
            // 
            // BTN_Solo
            // 
            this.BTN_Solo.Location = new System.Drawing.Point(143, 98);
            this.BTN_Solo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Solo.Name = "BTN_Solo";
            this.BTN_Solo.Size = new System.Drawing.Size(133, 34);
            this.BTN_Solo.TabIndex = 16;
            this.BTN_Solo.Text = "Apenas eu";
            this.BTN_Solo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantas pessoas há na sua equipe?";
            // 
            // UcQtdPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelQtdPessoas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcQtdPessoas";
            this.Size = new System.Drawing.Size(1920, 650);
            this.panelQtdPessoas.ResumeLayout(false);
            this.panelQtdPessoas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQtdPessoas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Equipe_G;
        private System.Windows.Forms.Button BTN_Equipe_P;
        private System.Windows.Forms.Button BTN_Solo;
        private System.Windows.Forms.Label label1;
    }
}
