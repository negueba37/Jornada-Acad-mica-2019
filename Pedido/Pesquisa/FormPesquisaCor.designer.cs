namespace Pedido.Pesquisa
{
    partial class FormPesquisaCor
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
            this.gbCores = new System.Windows.Forms.GroupBox();
            this.tbIDCor = new System.Windows.Forms.TextBox();
            this.bIncluir = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bExcluir = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lcDescricao = new System.Windows.Forms.Label();
            this.dgvCores = new System.Windows.Forms.DataGridView();
            this.colIDCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.lbIDCor = new System.Windows.Forms.Label();
            this.gbCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCores
            // 
            this.gbCores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCores.Controls.Add(this.tbIDCor);
            this.gbCores.Controls.Add(this.bIncluir);
            this.gbCores.Controls.Add(this.lbStatus);
            this.gbCores.Controls.Add(this.bAlterar);
            this.gbCores.Controls.Add(this.cbStatus);
            this.gbCores.Controls.Add(this.bExcluir);
            this.gbCores.Controls.Add(this.tbDescricao);
            this.gbCores.Controls.Add(this.bFechar);
            this.gbCores.Controls.Add(this.lcDescricao);
            this.gbCores.Controls.Add(this.dgvCores);
            this.gbCores.Controls.Add(this.bPesquisar);
            this.gbCores.Controls.Add(this.lbIDCor);
            this.gbCores.Location = new System.Drawing.Point(6, 3);
            this.gbCores.Name = "gbCores";
            this.gbCores.Size = new System.Drawing.Size(534, 352);
            this.gbCores.TabIndex = 14;
            this.gbCores.TabStop = false;
            this.gbCores.Text = "Cores";
            // 
            // tbIDCor
            // 
            this.tbIDCor.Location = new System.Drawing.Point(10, 32);
            this.tbIDCor.Name = "tbIDCor";
            this.tbIDCor.Size = new System.Drawing.Size(51, 20);
            this.tbIDCor.TabIndex = 1;
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
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(71, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status";
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
            this.bExcluir.TabIndex = 10;
            this.bExcluir.Text = "&Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(136, 32);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(307, 20);
            this.tbDescricao.TabIndex = 5;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(449, 320);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 11;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // lcDescricao
            // 
            this.lcDescricao.AutoSize = true;
            this.lcDescricao.Location = new System.Drawing.Point(136, 19);
            this.lcDescricao.Name = "lcDescricao";
            this.lcDescricao.Size = new System.Drawing.Size(55, 13);
            this.lcDescricao.TabIndex = 4;
            this.lcDescricao.Text = "Descrição";
            // 
            // dgvCores
            // 
            this.dgvCores.AllowUserToAddRows = false;
            this.dgvCores.AllowUserToDeleteRows = false;
            this.dgvCores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDCor,
            this.colStatus,
            this.colDescricao});
            this.dgvCores.Location = new System.Drawing.Point(9, 60);
            this.dgvCores.Name = "dgvCores";
            this.dgvCores.ReadOnly = true;
            this.dgvCores.RowHeadersWidth = 5;
            this.dgvCores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCores.Size = new System.Drawing.Size(515, 252);
            this.dgvCores.TabIndex = 7;
            // 
            // colIDCor
            // 
            this.colIDCor.HeaderText = "Código";
            this.colIDCor.Name = "colIDCor";
            this.colIDCor.ReadOnly = true;
            this.colIDCor.Width = 50;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Ativo";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 37;
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
            this.bPesquisar.Location = new System.Drawing.Point(449, 31);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bPesquisar.TabIndex = 6;
            this.bPesquisar.Text = "&Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // lbIDCor
            // 
            this.lbIDCor.AutoSize = true;
            this.lbIDCor.Location = new System.Drawing.Point(10, 19);
            this.lbIDCor.Name = "lbIDCor";
            this.lbIDCor.Size = new System.Drawing.Size(40, 13);
            this.lbIDCor.TabIndex = 0;
            this.lbIDCor.Text = "Código";
            // 
            // FormPesquisaCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 358);
            this.Controls.Add(this.gbCores);
            this.KeyPreview = true;
            this.Name = "FormPesquisaCor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de cores";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaCor_KeyDown);
            this.gbCores.ResumeLayout(false);
            this.gbCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCores;
        internal System.Windows.Forms.TextBox tbIDCor;
        internal System.Windows.Forms.Button bIncluir;
        internal System.Windows.Forms.Label lbStatus;
        internal System.Windows.Forms.Button bAlterar;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.Button bExcluir;
        internal System.Windows.Forms.TextBox tbDescricao;
        internal System.Windows.Forms.Button bFechar;
        internal System.Windows.Forms.Label lcDescricao;
        internal System.Windows.Forms.DataGridView dgvCores;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDCor;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        internal System.Windows.Forms.Button bPesquisar;
        internal System.Windows.Forms.Label lbIDCor;
    }
}