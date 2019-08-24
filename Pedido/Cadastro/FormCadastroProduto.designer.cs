namespace Pedido.Cadastro
{
    partial class FormCadastroProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gcCor = new System.Windows.Forms.GroupBox();
            this.gcTamanhoPrecos = new System.Windows.Forms.GroupBox();
            this.dgvProdutoTamanho = new System.Windows.Forms.DataGridView();
            this.colIDTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRemover = new System.Windows.Forms.Panel();
            this.bRemover = new System.Windows.Forms.Button();
            this.gcTamanhoPreco = new System.Windows.Forms.GroupBox();
            this.bCadastrarTamanho = new System.Windows.Forms.Button();
            this.cbIDTamanho = new System.Windows.Forms.ComboBox();
            this.lbIDTamanho = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.lcPreco = new System.Windows.Forms.Label();
            this.bAdicionar = new System.Windows.Forms.Button();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.tbIDProduto = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.bGravar = new System.Windows.Forms.Button();
            this.lDescricao = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lIDProduto = new System.Windows.Forms.Label();
            this.Validacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcCor.SuspendLayout();
            this.gcTamanhoPrecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoTamanho)).BeginInit();
            this.pRemover.SuspendLayout();
            this.gcTamanhoPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCor
            // 
            this.gcCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcCor.Controls.Add(this.gcTamanhoPrecos);
            this.gcCor.Controls.Add(this.gcTamanhoPreco);
            this.gcCor.Controls.Add(this.tbReferencia);
            this.gcCor.Controls.Add(this.lbReferencia);
            this.gcCor.Controls.Add(this.tbIDProduto);
            this.gcCor.Controls.Add(this.tbDescricao);
            this.gcCor.Controls.Add(this.bGravar);
            this.gcCor.Controls.Add(this.lDescricao);
            this.gcCor.Controls.Add(this.bCancelar);
            this.gcCor.Controls.Add(this.cbStatus);
            this.gcCor.Controls.Add(this.lIDProduto);
            this.gcCor.Location = new System.Drawing.Point(0, -1);
            this.gcCor.Name = "gcCor";
            this.gcCor.Size = new System.Drawing.Size(370, 474);
            this.gcCor.TabIndex = 1;
            this.gcCor.TabStop = false;
            this.gcCor.Text = "Informe os dados do cadastro";
            // 
            // gcTamanhoPrecos
            // 
            this.gcTamanhoPrecos.Controls.Add(this.dgvProdutoTamanho);
            this.gcTamanhoPrecos.Controls.Add(this.pRemover);
            this.gcTamanhoPrecos.Location = new System.Drawing.Point(10, 163);
            this.gcTamanhoPrecos.Name = "gcTamanhoPrecos";
            this.gcTamanhoPrecos.Size = new System.Drawing.Size(350, 270);
            this.gcTamanhoPrecos.TabIndex = 8;
            this.gcTamanhoPrecos.TabStop = false;
            this.gcTamanhoPrecos.Text = "Lista de preços";
            // 
            // dgvProdutoTamanho
            // 
            this.dgvProdutoTamanho.AllowUserToAddRows = false;
            this.dgvProdutoTamanho.AllowUserToDeleteRows = false;
            this.dgvProdutoTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoTamanho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDTamanho,
            this.colTamanho,
            this.colPreco});
            this.dgvProdutoTamanho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutoTamanho.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutoTamanho.Name = "dgvProdutoTamanho";
            this.dgvProdutoTamanho.ReadOnly = true;
            this.dgvProdutoTamanho.RowHeadersWidth = 5;
            this.dgvProdutoTamanho.Size = new System.Drawing.Size(344, 228);
            this.dgvProdutoTamanho.TabIndex = 0;
            // 
            // colIDTamanho
            // 
            this.colIDTamanho.HeaderText = "Código";
            this.colIDTamanho.Name = "colIDTamanho";
            this.colIDTamanho.ReadOnly = true;
            this.colIDTamanho.Width = 60;
            // 
            // colTamanho
            // 
            this.colTamanho.HeaderText = "Tamanho";
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.ReadOnly = true;
            this.colTamanho.Width = 70;
            // 
            // colPreco
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            this.colPreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            this.colPreco.Width = 120;
            // 
            // pRemover
            // 
            this.pRemover.Controls.Add(this.bRemover);
            this.pRemover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRemover.Location = new System.Drawing.Point(3, 244);
            this.pRemover.Name = "pRemover";
            this.pRemover.Size = new System.Drawing.Size(344, 23);
            this.pRemover.TabIndex = 1;
            // 
            // bRemover
            // 
            this.bRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRemover.Location = new System.Drawing.Point(269, 0);
            this.bRemover.Name = "bRemover";
            this.bRemover.Size = new System.Drawing.Size(75, 23);
            this.bRemover.TabIndex = 0;
            this.bRemover.Text = "&Remover";
            this.bRemover.UseVisualStyleBackColor = true;
            this.bRemover.Click += new System.EventHandler(this.bRemover_Click);
            // 
            // gcTamanhoPreco
            // 
            this.gcTamanhoPreco.Controls.Add(this.bCadastrarTamanho);
            this.gcTamanhoPreco.Controls.Add(this.cbIDTamanho);
            this.gcTamanhoPreco.Controls.Add(this.lbIDTamanho);
            this.gcTamanhoPreco.Controls.Add(this.tbPreco);
            this.gcTamanhoPreco.Controls.Add(this.lcPreco);
            this.gcTamanhoPreco.Controls.Add(this.bAdicionar);
            this.gcTamanhoPreco.Location = new System.Drawing.Point(10, 100);
            this.gcTamanhoPreco.Name = "gcTamanhoPreco";
            this.gcTamanhoPreco.Size = new System.Drawing.Size(350, 55);
            this.gcTamanhoPreco.TabIndex = 7;
            this.gcTamanhoPreco.TabStop = false;
            this.gcTamanhoPreco.Text = "Tamanho/Preço";
            // 
            // bCadastrarTamanho
            // 
            this.bCadastrarTamanho.Location = new System.Drawing.Point(136, 28);
            this.bCadastrarTamanho.Name = "bCadastrarTamanho";
            this.bCadastrarTamanho.Size = new System.Drawing.Size(24, 21);
            this.bCadastrarTamanho.TabIndex = 2;
            this.bCadastrarTamanho.TabStop = false;
            this.bCadastrarTamanho.Text = "+";
            this.bCadastrarTamanho.UseVisualStyleBackColor = true;
            this.bCadastrarTamanho.Click += new System.EventHandler(this.bCadastrarTamanho_Click);
            // 
            // cbIDTamanho
            // 
            this.cbIDTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDTamanho.FormattingEnabled = true;
            this.cbIDTamanho.Location = new System.Drawing.Point(6, 28);
            this.cbIDTamanho.Name = "cbIDTamanho";
            this.cbIDTamanho.Size = new System.Drawing.Size(113, 21);
            this.cbIDTamanho.TabIndex = 1;
            // 
            // lbIDTamanho
            // 
            this.lbIDTamanho.AutoSize = true;
            this.lbIDTamanho.ForeColor = System.Drawing.Color.Red;
            this.lbIDTamanho.Location = new System.Drawing.Point(6, 15);
            this.lbIDTamanho.Name = "lbIDTamanho";
            this.lbIDTamanho.Size = new System.Drawing.Size(52, 13);
            this.lbIDTamanho.TabIndex = 0;
            this.lbIDTamanho.Text = "Tamanho";
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(168, 28);
            this.tbPreco.MaxLength = 100;
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPreco.Size = new System.Drawing.Size(86, 20);
            this.tbPreco.TabIndex = 4;
            this.tbPreco.Text = "R$ 0,00";
            this.tbPreco.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            this.tbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPreco_KeyPress);
            // 
            // lcPreco
            // 
            this.lcPreco.AutoSize = true;
            this.lcPreco.ForeColor = System.Drawing.Color.Red;
            this.lcPreco.Location = new System.Drawing.Point(168, 15);
            this.lcPreco.Name = "lcPreco";
            this.lcPreco.Size = new System.Drawing.Size(35, 13);
            this.lcPreco.TabIndex = 3;
            this.lcPreco.Text = "Preço";
            // 
            // bAdicionar
            // 
            this.bAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdicionar.Location = new System.Drawing.Point(270, 26);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bAdicionar.TabIndex = 5;
            this.bAdicionar.Text = "&Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.bAdicionar_Click);
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(121, 31);
            this.tbReferencia.MaxLength = 200;
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(85, 20);
            this.tbReferencia.TabIndex = 4;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.ForeColor = System.Drawing.Color.Red;
            this.lbReferencia.Location = new System.Drawing.Point(121, 18);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 3;
            this.lbReferencia.Text = "Referência";
            // 
            // tbIDProduto
            // 
            this.tbIDProduto.Location = new System.Drawing.Point(10, 31);
            this.tbIDProduto.Name = "tbIDProduto";
            this.tbIDProduto.ReadOnly = true;
            this.tbIDProduto.Size = new System.Drawing.Size(47, 20);
            this.tbIDProduto.TabIndex = 1;
            this.tbIDProduto.TabStop = false;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(10, 72);
            this.tbDescricao.MaxLength = 200;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(350, 20);
            this.tbDescricao.TabIndex = 6;
            // 
            // bGravar
            // 
            this.bGravar.Location = new System.Drawing.Point(10, 441);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(75, 23);
            this.bGravar.TabIndex = 9;
            this.bGravar.Text = "&Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // lDescricao
            // 
            this.lDescricao.AutoSize = true;
            this.lDescricao.ForeColor = System.Drawing.Color.Red;
            this.lDescricao.Location = new System.Drawing.Point(10, 59);
            this.lDescricao.Name = "lDescricao";
            this.lDescricao.Size = new System.Drawing.Size(55, 13);
            this.lDescricao.TabIndex = 5;
            this.lDescricao.Text = "Descrição";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(93, 441);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(65, 33);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(50, 17);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.TabStop = false;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lIDProduto
            // 
            this.lIDProduto.AutoSize = true;
            this.lIDProduto.Location = new System.Drawing.Point(10, 18);
            this.lIDProduto.Name = "lIDProduto";
            this.lIDProduto.Size = new System.Drawing.Size(40, 13);
            this.lIDProduto.TabIndex = 0;
            this.lIDProduto.Text = "Código";
            // 
            // Validacao
            // 
            this.Validacao.ContainerControl = this;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 472);
            this.Controls.Add(this.gcCor);
            this.KeyPreview = true;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroProduto_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroProduto_KeyDown);
            this.gcCor.ResumeLayout(false);
            this.gcCor.PerformLayout();
            this.gcTamanhoPrecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoTamanho)).EndInit();
            this.pRemover.ResumeLayout(false);
            this.gcTamanhoPreco.ResumeLayout(false);
            this.gcTamanhoPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gcCor;
        internal System.Windows.Forms.GroupBox gcTamanhoPrecos;
        internal System.Windows.Forms.DataGridView dgvProdutoTamanho;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDTamanho;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        internal System.Windows.Forms.Panel pRemover;
        internal System.Windows.Forms.Button bRemover;
        internal System.Windows.Forms.GroupBox gcTamanhoPreco;
        internal System.Windows.Forms.Button bCadastrarTamanho;
        internal System.Windows.Forms.ComboBox cbIDTamanho;
        internal System.Windows.Forms.Label lbIDTamanho;
        internal System.Windows.Forms.TextBox tbPreco;
        internal System.Windows.Forms.Label lcPreco;
        internal System.Windows.Forms.Button bAdicionar;
        internal System.Windows.Forms.TextBox tbReferencia;
        internal System.Windows.Forms.Label lbReferencia;
        internal System.Windows.Forms.TextBox tbIDProduto;
        internal System.Windows.Forms.TextBox tbDescricao;
        internal System.Windows.Forms.Button bGravar;
        internal System.Windows.Forms.Label lDescricao;
        internal System.Windows.Forms.Button bCancelar;
        internal System.Windows.Forms.CheckBox cbStatus;
        internal System.Windows.Forms.Label lIDProduto;
        internal System.Windows.Forms.ErrorProvider Validacao;
    }
}