namespace Pedido.Pesquisa
{
    partial class FormPesquisaProduto
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
            this.gbTamanhos = new System.Windows.Forms.GroupBox();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.tbIDProduto = new System.Windows.Forms.TextBox();
            this.bIncluir = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bExcluir = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colIDProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.lIDProduto = new System.Windows.Forms.Label();
            this.gbTamanhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTamanhos
            // 
            this.gbTamanhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbTamanhos.Controls.Add(this.tbReferencia);
            this.gbTamanhos.Controls.Add(this.lbReferencia);
            this.gbTamanhos.Controls.Add(this.tbIDProduto);
            this.gbTamanhos.Controls.Add(this.bIncluir);
            this.gbTamanhos.Controls.Add(this.lStatus);
            this.gbTamanhos.Controls.Add(this.bAlterar);
            this.gbTamanhos.Controls.Add(this.cbStatus);
            this.gbTamanhos.Controls.Add(this.bExcluir);
            this.gbTamanhos.Controls.Add(this.tbDescricao);
            this.gbTamanhos.Controls.Add(this.bFechar);
            this.gbTamanhos.Controls.Add(this.Label2);
            this.gbTamanhos.Controls.Add(this.dgvProdutos);
            this.gbTamanhos.Controls.Add(this.bPesquisar);
            this.gbTamanhos.Controls.Add(this.lIDProduto);
            this.gbTamanhos.Location = new System.Drawing.Point(6, 3);
            this.gbTamanhos.Name = "gbTamanhos";
            this.gbTamanhos.Size = new System.Drawing.Size(534, 352);
            this.gbTamanhos.TabIndex = 1;
            this.gbTamanhos.TabStop = false;
            this.gbTamanhos.Text = "Tamanhos";
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(354, 32);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(86, 20);
            this.tbReferencia.TabIndex = 7;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(354, 19);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 6;
            this.lbReferencia.Text = "Referência";
            // 
            // tbIDProduto
            // 
            this.tbIDProduto.Location = new System.Drawing.Point(10, 32);
            this.tbIDProduto.Name = "tbIDProduto";
            this.tbIDProduto.Size = new System.Drawing.Size(51, 20);
            this.tbIDProduto.TabIndex = 1;
            // 
            // bIncluir
            // 
            this.bIncluir.Location = new System.Drawing.Point(9, 320);
            this.bIncluir.Name = "bIncluir";
            this.bIncluir.Size = new System.Drawing.Size(75, 23);
            this.bIncluir.TabIndex = 10;
            this.bIncluir.Text = "&Incluir";
            this.bIncluir.UseVisualStyleBackColor = true;
            this.bIncluir.Click += new System.EventHandler(this.bIncluir_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(71, 19);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(37, 13);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Status";
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(90, 320);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 11;
            this.bAlterar.Text = "&Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.DisplayMember = "Todos";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(71, 32);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(57, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // bExcluir
            // 
            this.bExcluir.Location = new System.Drawing.Point(171, 320);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 12;
            this.bExcluir.Text = "&Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(136, 32);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(210, 20);
            this.tbDescricao.TabIndex = 5;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(449, 320);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 14;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(136, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Descrição";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProduto,
            this.colStatus,
            this.colReferencia,
            this.colDescricao});
            this.dgvProdutos.Location = new System.Drawing.Point(9, 60);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 5;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(515, 252);
            this.dgvProdutos.TabIndex = 9;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // colIDProduto
            // 
            this.colIDProduto.HeaderText = "Código";
            this.colIDProduto.Name = "colIDProduto";
            this.colIDProduto.ReadOnly = true;
            this.colIDProduto.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Ativo";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 37;
            // 
            // colReferencia
            // 
            this.colReferencia.HeaderText = "Referência";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.ReadOnly = true;
            this.colReferencia.Width = 80;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descriçao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Location = new System.Drawing.Point(448, 30);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(76, 23);
            this.bPesquisar.TabIndex = 8;
            this.bPesquisar.Text = "&Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // lIDProduto
            // 
            this.lIDProduto.AutoSize = true;
            this.lIDProduto.Location = new System.Drawing.Point(10, 19);
            this.lIDProduto.Name = "lIDProduto";
            this.lIDProduto.Size = new System.Drawing.Size(40, 13);
            this.lIDProduto.TabIndex = 0;
            this.lIDProduto.Text = "Código";
            // 
            // FormPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 358);
            this.Controls.Add(this.gbTamanhos);
            this.KeyPreview = true;
            this.Name = "FormPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaProduto_KeyDown);
            this.gbTamanhos.ResumeLayout(false);
            this.gbTamanhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbTamanhos;
        internal System.Windows.Forms.TextBox tbReferencia;
        internal System.Windows.Forms.Label lbReferencia;
        internal System.Windows.Forms.TextBox tbIDProduto;
        internal System.Windows.Forms.Button bIncluir;
        internal System.Windows.Forms.Label lStatus;
        internal System.Windows.Forms.Button bAlterar;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.Button bExcluir;
        internal System.Windows.Forms.TextBox tbDescricao;
        internal System.Windows.Forms.Button bFechar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvProdutos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDProduto;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colReferencia;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        internal System.Windows.Forms.Button bPesquisar;
        internal System.Windows.Forms.Label lIDProduto;
    }
}