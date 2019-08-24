namespace Pedido.Pesquisa
{
    partial class FormPesquisaPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPessoas = new System.Windows.Forms.GroupBox();
            this.mtbDataFim = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lbDe = new System.Windows.Forms.Label();
            this.lbAte = new System.Windows.Forms.Label();
            this.lbDataPedido = new System.Windows.Forms.Label();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbApelido_Fantasia = new System.Windows.Forms.TextBox();
            this.lbApelido_Fantasia = new System.Windows.Forms.Label();
            this.tbRG_InscricaoEstadual = new System.Windows.Forms.TextBox();
            this.lbRG_InscricaoEstadual = new System.Windows.Forms.Label();
            this.tbCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.lbCPF_CNPJ = new System.Windows.Forms.Label();
            this.tbIDPedido = new System.Windows.Forms.TextBox();
            this.bIncluir = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bExcluir = new System.Windows.Forms.Button();
            this.tbNome_RazaoSocial = new System.Windows.Forms.TextBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lcNome_RazaoSocial = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.colIDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.lIDPessoa = new System.Windows.Forms.Label();
            this.gbPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPessoas
            // 
            this.gbPessoas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPessoas.Controls.Add(this.mtbDataFim);
            this.gbPessoas.Controls.Add(this.mtbDataInicio);
            this.gbPessoas.Controls.Add(this.lbDe);
            this.gbPessoas.Controls.Add(this.lbAte);
            this.gbPessoas.Controls.Add(this.lbDataPedido);
            this.gbPessoas.Controls.Add(this.tbUF);
            this.gbPessoas.Controls.Add(this.lbUF);
            this.gbPessoas.Controls.Add(this.tbCidade);
            this.gbPessoas.Controls.Add(this.lbCidade);
            this.gbPessoas.Controls.Add(this.tbApelido_Fantasia);
            this.gbPessoas.Controls.Add(this.lbApelido_Fantasia);
            this.gbPessoas.Controls.Add(this.tbRG_InscricaoEstadual);
            this.gbPessoas.Controls.Add(this.lbRG_InscricaoEstadual);
            this.gbPessoas.Controls.Add(this.tbCPF_CNPJ);
            this.gbPessoas.Controls.Add(this.lbCPF_CNPJ);
            this.gbPessoas.Controls.Add(this.tbIDPedido);
            this.gbPessoas.Controls.Add(this.bIncluir);
            this.gbPessoas.Controls.Add(this.lStatus);
            this.gbPessoas.Controls.Add(this.bAlterar);
            this.gbPessoas.Controls.Add(this.cbStatus);
            this.gbPessoas.Controls.Add(this.bExcluir);
            this.gbPessoas.Controls.Add(this.tbNome_RazaoSocial);
            this.gbPessoas.Controls.Add(this.bFechar);
            this.gbPessoas.Controls.Add(this.lcNome_RazaoSocial);
            this.gbPessoas.Controls.Add(this.dgvPedidos);
            this.gbPessoas.Controls.Add(this.bPesquisar);
            this.gbPessoas.Controls.Add(this.lIDPessoa);
            this.gbPessoas.Location = new System.Drawing.Point(0, 0);
            this.gbPessoas.Name = "gbPessoas";
            this.gbPessoas.Size = new System.Drawing.Size(749, 497);
            this.gbPessoas.TabIndex = 1;
            this.gbPessoas.TabStop = false;
            this.gbPessoas.Text = "Pedidos";
            // 
            // mtbDataFim
            // 
            this.mtbDataFim.Location = new System.Drawing.Point(350, 73);
            this.mtbDataFim.Mask = "99/99/9999";
            this.mtbDataFim.Name = "mtbDataFim";
            this.mtbDataFim.Size = new System.Drawing.Size(100, 20);
            this.mtbDataFim.TabIndex = 29;
            // 
            // mtbDataInicio
            // 
            this.mtbDataInicio.Location = new System.Drawing.Point(211, 73);
            this.mtbDataInicio.Mask = "99/99/9999";
            this.mtbDataInicio.Name = "mtbDataInicio";
            this.mtbDataInicio.Size = new System.Drawing.Size(100, 20);
            this.mtbDataInicio.TabIndex = 28;
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(182, 77);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(21, 13);
            this.lbDe.TabIndex = 27;
            this.lbDe.Text = "De";
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(319, 77);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(23, 13);
            this.lbAte.TabIndex = 25;
            this.lbAte.Text = "Até";
            // 
            // lbDataPedido
            // 
            this.lbDataPedido.AutoSize = true;
            this.lbDataPedido.Location = new System.Drawing.Point(180, 60);
            this.lbDataPedido.Name = "lbDataPedido";
            this.lbDataPedido.Size = new System.Drawing.Size(95, 13);
            this.lbDataPedido.TabIndex = 23;
            this.lbDataPedido.Text = "Período do pedido";
            // 
            // tbUF
            // 
            this.tbUF.Location = new System.Drawing.Point(134, 73);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(40, 20);
            this.tbUF.TabIndex = 15;
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.Location = new System.Drawing.Point(134, 61);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(21, 13);
            this.lbUF.TabIndex = 14;
            this.lbUF.Text = "UF";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(10, 73);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(116, 20);
            this.tbCidade.TabIndex = 13;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(10, 60);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 12;
            this.lbCidade.Text = "Cidade";
            // 
            // tbApelido_Fantasia
            // 
            this.tbApelido_Fantasia.Location = new System.Drawing.Point(351, 32);
            this.tbApelido_Fantasia.Name = "tbApelido_Fantasia";
            this.tbApelido_Fantasia.Size = new System.Drawing.Size(127, 20);
            this.tbApelido_Fantasia.TabIndex = 7;
            // 
            // lbApelido_Fantasia
            // 
            this.lbApelido_Fantasia.AutoSize = true;
            this.lbApelido_Fantasia.Location = new System.Drawing.Point(351, 19);
            this.lbApelido_Fantasia.Name = "lbApelido_Fantasia";
            this.lbApelido_Fantasia.Size = new System.Drawing.Size(87, 13);
            this.lbApelido_Fantasia.TabIndex = 6;
            this.lbApelido_Fantasia.Text = "Apelido/Fantasia";
            // 
            // tbRG_InscricaoEstadual
            // 
            this.tbRG_InscricaoEstadual.Location = new System.Drawing.Point(619, 32);
            this.tbRG_InscricaoEstadual.Name = "tbRG_InscricaoEstadual";
            this.tbRG_InscricaoEstadual.Size = new System.Drawing.Size(120, 20);
            this.tbRG_InscricaoEstadual.TabIndex = 11;
            // 
            // lbRG_InscricaoEstadual
            // 
            this.lbRG_InscricaoEstadual.AutoSize = true;
            this.lbRG_InscricaoEstadual.Location = new System.Drawing.Point(619, 19);
            this.lbRG_InscricaoEstadual.Name = "lbRG_InscricaoEstadual";
            this.lbRG_InscricaoEstadual.Size = new System.Drawing.Size(89, 13);
            this.lbRG_InscricaoEstadual.TabIndex = 10;
            this.lbRG_InscricaoEstadual.Text = "RG/InscEstadual";
            // 
            // tbCPF_CNPJ
            // 
            this.tbCPF_CNPJ.Location = new System.Drawing.Point(486, 32);
            this.tbCPF_CNPJ.Name = "tbCPF_CNPJ";
            this.tbCPF_CNPJ.Size = new System.Drawing.Size(125, 20);
            this.tbCPF_CNPJ.TabIndex = 9;
            // 
            // lbCPF_CNPJ
            // 
            this.lbCPF_CNPJ.AutoSize = true;
            this.lbCPF_CNPJ.Location = new System.Drawing.Point(486, 19);
            this.lbCPF_CNPJ.Name = "lbCPF_CNPJ";
            this.lbCPF_CNPJ.Size = new System.Drawing.Size(59, 13);
            this.lbCPF_CNPJ.TabIndex = 8;
            this.lbCPF_CNPJ.Text = "CPF/CNPJ";
            // 
            // tbIDPedido
            // 
            this.tbIDPedido.Location = new System.Drawing.Point(10, 32);
            this.tbIDPedido.Name = "tbIDPedido";
            this.tbIDPedido.Size = new System.Drawing.Size(51, 20);
            this.tbIDPedido.TabIndex = 1;
            // 
            // bIncluir
            // 
            this.bIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bIncluir.Location = new System.Drawing.Point(9, 465);
            this.bIncluir.Name = "bIncluir";
            this.bIncluir.Size = new System.Drawing.Size(75, 23);
            this.bIncluir.TabIndex = 18;
            this.bIncluir.Text = "&Incluir";
            this.bIncluir.UseVisualStyleBackColor = true;
            this.bIncluir.Click += new System.EventHandler(this.bIncluir_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(69, 19);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(37, 13);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Status";
            // 
            // bAlterar
            // 
            this.bAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAlterar.Location = new System.Drawing.Point(90, 465);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 19;
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
            "Aberto",
            "Fechado"});
            this.cbStatus.Location = new System.Drawing.Point(69, 32);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(57, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // bExcluir
            // 
            this.bExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExcluir.Location = new System.Drawing.Point(171, 465);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 20;
            this.bExcluir.Text = "&Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // tbNome_RazaoSocial
            // 
            this.tbNome_RazaoSocial.Location = new System.Drawing.Point(134, 32);
            this.tbNome_RazaoSocial.Name = "tbNome_RazaoSocial";
            this.tbNome_RazaoSocial.Size = new System.Drawing.Size(209, 20);
            this.tbNome_RazaoSocial.TabIndex = 5;
            // 
            // bFechar
            // 
            this.bFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFechar.Location = new System.Drawing.Point(664, 465);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 22;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // lcNome_RazaoSocial
            // 
            this.lcNome_RazaoSocial.AutoSize = true;
            this.lcNome_RazaoSocial.Location = new System.Drawing.Point(134, 19);
            this.lcNome_RazaoSocial.Name = "lcNome_RazaoSocial";
            this.lcNome_RazaoSocial.Size = new System.Drawing.Size(103, 13);
            this.lcNome_RazaoSocial.TabIndex = 4;
            this.lcNome_RazaoSocial.Text = "Nome/Razão Social";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPedido,
            this.colIDPessoa,
            this.colNomeRazaoSocial,
            this.colStatus,
            this.colData,
            this.colTotal,
            this.colCidade,
            this.colUF});
            this.dgvPedidos.Location = new System.Drawing.Point(9, 101);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 5;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(730, 356);
            this.dgvPedidos.TabIndex = 17;
            // 
            // colIDPedido
            // 
            this.colIDPedido.HeaderText = "Código";
            this.colIDPedido.Name = "colIDPedido";
            this.colIDPedido.ReadOnly = true;
            this.colIDPedido.Width = 50;
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.HeaderText = "Cod. Cliente";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.ReadOnly = true;
            // 
            // colNomeRazaoSocial
            // 
            this.colNomeRazaoSocial.HeaderText = "Nome/Razão Social";
            this.colNomeRazaoSocial.Name = "colNomeRazaoSocial";
            this.colNomeRazaoSocial.ReadOnly = true;
            this.colNomeRazaoSocial.Width = 180;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colData
            // 
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.colData.DefaultCellStyle = dataGridViewCellStyle13;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle14;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colUF
            // 
            this.colUF.HeaderText = "UF";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Width = 60;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPesquisar.Location = new System.Drawing.Point(664, 70);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bPesquisar.TabIndex = 16;
            this.bPesquisar.Text = "&Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // lIDPessoa
            // 
            this.lIDPessoa.AutoSize = true;
            this.lIDPessoa.Location = new System.Drawing.Point(10, 19);
            this.lIDPessoa.Name = "lIDPessoa";
            this.lIDPessoa.Size = new System.Drawing.Size(40, 13);
            this.lIDPessoa.TabIndex = 0;
            this.lIDPessoa.Text = "Código";
            // 
            // FormPesquisaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 496);
            this.Controls.Add(this.gbPessoas);
            this.KeyPreview = true;
            this.Name = "FormPesquisaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de pedidos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaPedido_KeyDown);
            this.gbPessoas.ResumeLayout(false);
            this.gbPessoas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbPessoas;
        internal System.Windows.Forms.MaskedTextBox mtbDataFim;
        internal System.Windows.Forms.MaskedTextBox mtbDataInicio;
        internal System.Windows.Forms.Label lbDe;
        internal System.Windows.Forms.Label lbAte;
        internal System.Windows.Forms.Label lbDataPedido;
        internal System.Windows.Forms.TextBox tbUF;
        internal System.Windows.Forms.Label lbUF;
        internal System.Windows.Forms.TextBox tbCidade;
        internal System.Windows.Forms.Label lbCidade;
        internal System.Windows.Forms.TextBox tbApelido_Fantasia;
        internal System.Windows.Forms.Label lbApelido_Fantasia;
        internal System.Windows.Forms.TextBox tbRG_InscricaoEstadual;
        internal System.Windows.Forms.Label lbRG_InscricaoEstadual;
        internal System.Windows.Forms.TextBox tbCPF_CNPJ;
        internal System.Windows.Forms.Label lbCPF_CNPJ;
        internal System.Windows.Forms.TextBox tbIDPedido;
        internal System.Windows.Forms.Button bIncluir;
        internal System.Windows.Forms.Label lStatus;
        internal System.Windows.Forms.Button bAlterar;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.Button bExcluir;
        internal System.Windows.Forms.TextBox tbNome_RazaoSocial;
        internal System.Windows.Forms.Button bFechar;
        internal System.Windows.Forms.Label lcNome_RazaoSocial;
        internal System.Windows.Forms.DataGridView dgvPedidos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDPedido;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colIDPessoa;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNomeRazaoSocial;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colData;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colUF;
        internal System.Windows.Forms.Button bPesquisar;
        internal System.Windows.Forms.Label lIDPessoa;
    }
}