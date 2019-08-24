namespace Pedido.Pesquisa
{
    partial class FormPesquisaEstado
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
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.lUF = new System.Windows.Forms.Label();
            this.tbIDEstado = new System.Windows.Forms.TextBox();
            this.bIncluir = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lNome = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.colIDEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.lIDEstado = new System.Windows.Forms.Label();
            this.gbEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstados
            // 
            this.gbEstados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbEstados.Controls.Add(this.tbUF);
            this.gbEstados.Controls.Add(this.lUF);
            this.gbEstados.Controls.Add(this.tbIDEstado);
            this.gbEstados.Controls.Add(this.bIncluir);
            this.gbEstados.Controls.Add(this.bAlterar);
            this.gbEstados.Controls.Add(this.bExcluir);
            this.gbEstados.Controls.Add(this.tbNome);
            this.gbEstados.Controls.Add(this.bFechar);
            this.gbEstados.Controls.Add(this.lNome);
            this.gbEstados.Controls.Add(this.dgvEstados);
            this.gbEstados.Controls.Add(this.bPesquisar);
            this.gbEstados.Controls.Add(this.lIDEstado);
            this.gbEstados.Location = new System.Drawing.Point(6, 3);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(534, 352);
            this.gbEstados.TabIndex = 1;
            this.gbEstados.TabStop = false;
            this.gbEstados.Text = "Estados";
            // 
            // tbUF
            // 
            this.tbUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUF.Location = new System.Drawing.Point(238, 32);
            this.tbUF.MaxLength = 2;
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(35, 20);
            this.tbUF.TabIndex = 5;
            // 
            // lUF
            // 
            this.lUF.AutoSize = true;
            this.lUF.Location = new System.Drawing.Point(238, 18);
            this.lUF.Name = "lUF";
            this.lUF.Size = new System.Drawing.Size(21, 13);
            this.lUF.TabIndex = 4;
            this.lUF.Text = "UF";
            // 
            // tbIDEstado
            // 
            this.tbIDEstado.Location = new System.Drawing.Point(10, 32);
            this.tbIDEstado.Name = "tbIDEstado";
            this.tbIDEstado.Size = new System.Drawing.Size(51, 20);
            this.tbIDEstado.TabIndex = 1;
            // 
            // bIncluir
            // 
            this.bIncluir.Location = new System.Drawing.Point(9, 320);
            this.bIncluir.Name = "bIncluir";
            this.bIncluir.Size = new System.Drawing.Size(75, 23);
            this.bIncluir.TabIndex = 8;
            this.bIncluir.Text = "&Incluir";
            this.bIncluir.UseVisualStyleBackColor = true;
            this.bIncluir.Click += new System.EventHandler(this.bIncluir_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(90, 320);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 9;
            this.bAlterar.Text = "&Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Location = new System.Drawing.Point(171, 320);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 10;
            this.bExcluir.Text = "&Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(69, 32);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(161, 20);
            this.tbNome.TabIndex = 3;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(449, 320);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 12;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(67, 19);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 2;
            this.lNome.Text = "Nome";
            // 
            // dgvEstados
            // 
            this.dgvEstados.AllowUserToAddRows = false;
            this.dgvEstados.AllowUserToDeleteRows = false;
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEstado,
            this.colDescricao,
            this.colUF});
            this.dgvEstados.Location = new System.Drawing.Point(9, 60);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.ReadOnly = true;
            this.dgvEstados.RowHeadersWidth = 5;
            this.dgvEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstados.Size = new System.Drawing.Size(515, 252);
            this.dgvEstados.TabIndex = 7;
            // 
            // colIDEstado
            // 
            this.colIDEstado.HeaderText = "Código";
            this.colIDEstado.Name = "colIDEstado";
            this.colIDEstado.ReadOnly = true;
            this.colIDEstado.Width = 50;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Nome";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 150;
            // 
            // colUF
            // 
            this.colUF.HeaderText = "UF";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Width = 40;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Location = new System.Drawing.Point(449, 31);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bPesquisar.TabIndex = 6;
            this.bPesquisar.Text = "&Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // lIDEstado
            // 
            this.lIDEstado.AutoSize = true;
            this.lIDEstado.Location = new System.Drawing.Point(10, 19);
            this.lIDEstado.Name = "lIDEstado";
            this.lIDEstado.Size = new System.Drawing.Size(40, 13);
            this.lIDEstado.TabIndex = 0;
            this.lIDEstado.Text = "Código";
            // 
            // FormPesquisaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 359);
            this.Controls.Add(this.gbEstados);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(563, 397);
            this.Name = "FormPesquisaEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de estados";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaEstado_KeyDown);
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbEstados;
        internal System.Windows.Forms.TextBox tbUF;
        internal System.Windows.Forms.Label lUF;
        internal System.Windows.Forms.TextBox tbIDEstado;
        internal System.Windows.Forms.Button bIncluir;
        internal System.Windows.Forms.Button bAlterar;
        internal System.Windows.Forms.Button bExcluir;
        internal System.Windows.Forms.TextBox tbNome;
        internal System.Windows.Forms.Button bFechar;
        internal System.Windows.Forms.Label lNome;
        internal System.Windows.Forms.DataGridView dgvEstados;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDEstado;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colUF;
        internal System.Windows.Forms.Button bPesquisar;
        internal System.Windows.Forms.Label lIDEstado;
    }
}