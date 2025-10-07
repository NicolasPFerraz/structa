namespace structa_front
{
    partial class UcPaginaInicial
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
            this.lblNotificacoesComMencao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNotificacoesComMencao
            // 
            this.lblNotificacoesComMencao.AutoSize = true;
            this.lblNotificacoesComMencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotificacoesComMencao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNotificacoesComMencao.Location = new System.Drawing.Point(553, 420);
            this.lblNotificacoesComMencao.Name = "lblNotificacoesComMencao";
            this.lblNotificacoesComMencao.Size = new System.Drawing.Size(69, 13);
            this.lblNotificacoesComMencao.TabIndex = 36;
            this.lblNotificacoesComMencao.Text = "Página inicial";
            // 
            // UcPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotificacoesComMencao);
            this.Name = "UcPaginaInicial";
            this.Size = new System.Drawing.Size(1177, 861);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacoesComMencao;
    }
}
