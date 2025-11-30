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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panelToolbar = new FlowLayoutPanel();
            btnCriarElemento = new Button();
            btnPessoas = new Button();
            btnFiltro = new Button();
            btnOrdenar = new Button();
            btnOcultar = new Button();
            // btnVisualizacoes REMOVIDO
            panelHeaderEsteMes = new Panel();
            lblEsteMes = new Label();
            panelTarefasGrid = new Panel();
            dgvTarefas = new DataGridView();
            btnAdicionarGrupo = new Button();
            // contextMenuStripVisualizacoes e seus items REMOVIDOS
            panelToolbar.SuspendLayout();
            panelHeaderEsteMes.SuspendLayout();
            panelTarefasGrid.SuspendLayout();
            ((ISupportInitialize)dgvTarefas).BeginInit();
            // contextMenuStripVisualizacoes.SuspendLayout() REMOVIDO
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(14, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(242, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Plano de gestão";
            // 
            // panelToolbar
            // 
            panelToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelToolbar.Controls.Add(btnCriarElemento);
            panelToolbar.Controls.Add(btnPessoas);
            panelToolbar.Controls.Add(btnFiltro);
            panelToolbar.Controls.Add(btnOrdenar);
            panelToolbar.Controls.Add(btnOcultar);
            panelToolbar.Location = new Point(17, 55);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1122, 40);
            panelToolbar.TabIndex = 1;
            panelToolbar.Paint += panelToolbar_Paint;
            // 
            // btnCriarElemento
            // 
            btnCriarElemento.BackColor = Color.FromArgb(29, 78, 216);
            btnCriarElemento.FlatAppearance.BorderSize = 0;
            btnCriarElemento.FlatStyle = FlatStyle.Flat;
            btnCriarElemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarElemento.ForeColor = Color.White;
            btnCriarElemento.Location = new Point(3, 3);
            btnCriarElemento.Name = "btnCriarElemento";
            btnCriarElemento.Size = new Size(120, 30);
            btnCriarElemento.TabIndex = 0;
            btnCriarElemento.Text = "Criar Elemento ▾";
            btnCriarElemento.UseVisualStyleBackColor = false;
            btnCriarElemento.Click += btnCriarElemento_Click;
            // 
            // btnPessoas
            // 
            btnPessoas.BackColor = Color.FromArgb(45, 47, 90);
            btnPessoas.FlatAppearance.BorderSize = 0;
            btnPessoas.FlatStyle = FlatStyle.Flat;
            btnPessoas.ForeColor = Color.White;
            btnPessoas.Location = new Point(129, 3);
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
            btnFiltro.Location = new Point(210, 3);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 30);
            btnFiltro.TabIndex = 2;
            btnFiltro.Text = "Filtro";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click_1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.FromArgb(45, 47, 90);
            btnOrdenar.FlatAppearance.BorderSize = 0;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.ForeColor = Color.White;
            btnOrdenar.Location = new Point(291, 3);
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
            btnOcultar.Location = new Point(372, 3);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(130, 30);
            btnOcultar.TabIndex = 4;
            btnOcultar.Text = "Ocultar Concluídas";
            btnOcultar.UseVisualStyleBackColor = false;
            // 
            // btnVisualizacoes
            // 
            // Bloco btnVisualizacoes REMOVIDO
            // 
            // panelHeaderEsteMes
            // 
            panelHeaderEsteMes.Controls.Add(lblEsteMes);
            panelHeaderEsteMes.Location = new Point(17, 101);
            panelHeaderEsteMes.Name = "panelHeaderEsteMes";
            panelHeaderEsteMes.Size = new Size(200, 28);
            panelHeaderEsteMes.TabIndex = 2;
            panelHeaderEsteMes.Paint += panelHeaderEsteMes_Paint;
            // 
            // lblEsteMes
            // 
            lblEsteMes.AutoSize = true;
            lblEsteMes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsteMes.ForeColor = Color.White;
            lblEsteMes.Location = new Point(3, 3);
            lblEsteMes.Name = "lblEsteMes";
            lblEsteMes.Size = new Size(119, 28);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 47, 90);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTarefas.ColumnHeadersHeight = 40;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 47, 90);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 78, 130);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTarefas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTarefas.Dock = DockStyle.Fill;
            dgvTarefas.EnableHeadersVisualStyles = false;
            dgvTarefas.GridColor = Color.FromArgb(75, 78, 130);
            dgvTarefas.Location = new Point(0, 0);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersVisible = false;
            dgvTarefas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 47, 90);
            dgvTarefas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTarefas.RowTemplate.Height = 30;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.Size = new Size(1219, 304);
            dgvTarefas.TabIndex = 0;
            dgvTarefas.CellClick += dgvTarefas_CellClick;
            dgvTarefas.CellContentClick += dgvTarefas_CellContentClick;
            dgvTarefas.CellEndEdit += DataGridView1_CellEndEdit;
            // 
            // btnAdicionarGrupo
            // 
            btnAdicionarGrupo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionarGrupo.BackColor = Color.FromArgb(45, 47, 90);
            btnAdicionarGrupo.FlatAppearance.BorderSize = 0;
            btnAdicionarGrupo.FlatStyle = FlatStyle.Flat;
            btnAdicionarGrupo.ForeColor = Color.White;
            btnAdicionarGrupo.Location = new Point(17, 445);
            btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            btnAdicionarGrupo.Size = new Size(140, 30);
            btnAdicionarGrupo.TabIndex = 4;
            btnAdicionarGrupo.Text = "+ Adicionar novo grupo";
            btnAdicionarGrupo.UseVisualStyleBackColor = false;
            // 
            // contextMenuStripVisualizacoes
            // 
            // Bloco contextMenuStripVisualizacoes REMOVIDO
            // 
            // tabelaToolStripMenuItem
            // 
            // Bloco tabelaToolStripMenuItem REMOVIDO
            // 
            // gráficoToolStripMenuItem
            // 
            // Bloco gráficoToolStripMenuItem REMOVIDO
            // 
            // calendárioToolStripMenuItem
            // 
            // Bloco calendárioToolStripMenuItem REMOVIDO
            // 
            // kanbanToolStripMenuItem
            // 
            // Bloco kanbanToolStripMenuItem REMOVIDO
            // 
            // UcPlanoDeGestao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 58);
            Controls.Add(btnAdicionarGrupo);
            Controls.Add(panelTarefasGrid);
            Controls.Add(panelHeaderEsteMes);
            // Controls.Add(btnVisualizacoes) REMOVIDO
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
            // contextMenuStripVisualizacoes.ResumeLayout(false) REMOVIDO
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel panelToolbar;
        private System.Windows.Forms.Button btnCriarElemento;
        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnOcultar;
        // btnVisualizacoes REMOVIDO
        private System.Windows.Forms.Panel panelHeaderEsteMes;
        private System.Windows.Forms.Label lblEsteMes;
        private System.Windows.Forms.Panel panelTarefasGrid;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnAdicionarGrupo;
        // contextMenuStripVisualizacoes e seus items REMOVIDOS
    }
}