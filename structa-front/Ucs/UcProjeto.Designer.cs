using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structa_front
{
    partial class UcPlanoDeGestao
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panelToolbar = new FlowLayoutPanel();
            btnPessoas = new Button();
            btnFiltro = new Button();
            btnOrdenar = new Button();
            btnOcultar = new Button();
            panelHeaderEsteMes = new Panel();
            lblEsteMes = new Label();
            panelTarefasGrid = new Panel();
            dgvTarefas = new DataGridView();
            panelToolbar.SuspendLayout();
            panelHeaderEsteMes.SuspendLayout();
            panelTarefasGrid.SuspendLayout();
            ((ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Plano de gestão";
            // 
            // panelToolbar
            // 
            panelToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelToolbar.Controls.Add(btnPessoas);
            panelToolbar.Controls.Add(btnFiltro);
            panelToolbar.Controls.Add(btnOrdenar);
            panelToolbar.Controls.Add(btnOcultar);
            panelToolbar.Location = new Point(17, 55);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1122, 40);
            panelToolbar.TabIndex = 1;
            // 
            // btnPessoas
            // 
            btnPessoas.BackColor = Color.FromArgb(45, 47, 90);
            btnPessoas.FlatAppearance.BorderSize = 0;
            btnPessoas.FlatStyle = FlatStyle.Flat;
            btnPessoas.ForeColor = Color.White;
            btnPessoas.Location = new Point(3, 3);
            btnPessoas.Name = "btnPessoas";
            btnPessoas.Size = new Size(75, 30);
            btnPessoas.TabIndex = 1;
            btnPessoas.Text = "Pessoas";
            btnPessoas.UseVisualStyleBackColor = false;
            btnPessoas.Click += btnPessoas_Click;
            // 
            // btnFiltro
            // 
            btnFiltro.BackColor = Color.FromArgb(45, 47, 90);
            btnFiltro.FlatAppearance.BorderSize = 0;
            btnFiltro.FlatStyle = FlatStyle.Flat;
            btnFiltro.ForeColor = Color.White;
            btnFiltro.Location = new Point(84, 3);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 30);
            btnFiltro.TabIndex = 2;
            btnFiltro.Text = "Filtro";
            btnFiltro.UseVisualStyleBackColor = false;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.FromArgb(45, 47, 90);
            btnOrdenar.FlatAppearance.BorderSize = 0;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.ForeColor = Color.White;
            btnOrdenar.Location = new Point(165, 3);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 30);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // btnOcultar
            // 
            btnOcultar.BackColor = Color.FromArgb(45, 47, 90);
            btnOcultar.FlatAppearance.BorderSize = 0;
            btnOcultar.FlatStyle = FlatStyle.Flat;
            btnOcultar.ForeColor = Color.White;
            btnOcultar.Location = new Point(246, 3);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(130, 30);
            btnOcultar.TabIndex = 4;
            btnOcultar.Text = "Ocultar Concluídas";
            btnOcultar.UseVisualStyleBackColor = false;
            // 
            // panelHeaderEsteMes
            // 
            panelHeaderEsteMes.Controls.Add(lblEsteMes);
            panelHeaderEsteMes.Location = new Point(17, 101);
            panelHeaderEsteMes.Name = "panelHeaderEsteMes";
            panelHeaderEsteMes.Size = new Size(200, 28);
            panelHeaderEsteMes.TabIndex = 2;
            // 
            // lblEsteMes
            // 
            lblEsteMes.AutoSize = true;
            lblEsteMes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsteMes.ForeColor = Color.White;
            lblEsteMes.Location = new Point(3, 3);
            lblEsteMes.Name = "lblEsteMes";
            lblEsteMes.Size = new Size(95, 21);
            lblEsteMes.TabIndex = 0;
            lblEsteMes.Text = "▾ Este mês";
            lblEsteMes.Click += HeaderEsteMes_Click;
            // 
            // panelTarefasGrid
            // 
            panelTarefasGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTarefasGrid.Controls.Add(dgvTarefas);
            panelTarefasGrid.Location = new Point(17, 135);
            panelTarefasGrid.Name = "panelTarefasGrid";
            panelTarefasGrid.Size = new Size(1219, 304);
            panelTarefasGrid.TabIndex = 3;
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dgvTarefas.AllowUserToResizeRows = false;
            dgvTarefas.BackgroundColor = Color.FromArgb(45, 47, 90);
            dgvTarefas.BorderStyle = BorderStyle.None;
            dgvTarefas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTarefas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 47, 90);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTarefas.ColumnHeadersHeight = 40;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 47, 90);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(75, 78, 130);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTarefas.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTarefas.Dock = DockStyle.Fill;
            dgvTarefas.EnableHeadersVisualStyles = false;
            dgvTarefas.GridColor = Color.FromArgb(75, 78, 130);
            dgvTarefas.Location = new Point(0, 0);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersVisible = false;
            dgvTarefas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 47, 90);
            dgvTarefas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvTarefas.RowTemplate.Height = 30;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.Size = new Size(1219, 304);
            dgvTarefas.TabIndex = 0;
            dgvTarefas.CellContentClick += dgvTarefas_CellContentClick;
            dgvTarefas.CellEndEdit += DataGridView1_CellEndEdit;
            // 
            // UcPlanoDeGestao
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 58);
            Controls.Add(panelTarefasGrid);
            Controls.Add(panelHeaderEsteMes);
            Controls.Add(panelToolbar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UcPlanoDeGestao";
            Size = new Size(1255, 496);
            Load += UcPlanoDeGestao_Load;
            panelToolbar.ResumeLayout(false);
            panelHeaderEsteMes.ResumeLayout(false);
            panelHeaderEsteMes.PerformLayout();
            panelTarefasGrid.ResumeLayout(false);
            ((ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel panelToolbar;
        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnOcultar;
        // btnVisualizacoes REMOVIDO
        private System.Windows.Forms.Panel panelHeaderEsteMes;
        private System.Windows.Forms.Label lblEsteMes;
        private System.Windows.Forms.Panel panelTarefasGrid;
        private System.Windows.Forms.DataGridView dgvTarefas;
        // contextMenuStripVisualizacoes e seus items REMOVIDOS
    }
}