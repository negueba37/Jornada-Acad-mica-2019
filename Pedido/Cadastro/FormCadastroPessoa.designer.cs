namespace Pedido.Cadastro
{
    partial class FormCadastroPessoa
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
            this.gcCor = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.bCadastrarCidade = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lcComplemento = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lcTelefone = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbRG_IncricaoEstadual = new System.Windows.Forms.TextBox();
            this.lbRG_IncricaoEstadual = new System.Windows.Forms.Label();
            this.tbApelido_Fantasia = new System.Windows.Forms.TextBox();
            this.lbApelido_Fantasia = new System.Windows.Forms.Label();
            this.mtbCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF_CNPJ = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tbIDPessoa = new System.Windows.Forms.TextBox();
            this.tbNomeRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbNomeRazaoSocial = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbIDPessoa = new System.Windows.Forms.Label();
            this.bGravar = new System.Windows.Forms.Button();
            this.Validacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcCor.SuspendLayout();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCor
            // 
            this.gcCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcCor.Controls.Add(this.cbUF);
            this.gcCor.Controls.Add(this.lbUF);
            this.gcCor.Controls.Add(this.bCadastrarCidade);
            this.gcCor.Controls.Add(this.tbEmail);
            this.gcCor.Controls.Add(this.lbEmail);
            this.gcCor.Controls.Add(this.tbComplemento);
            this.gcCor.Controls.Add(this.lcComplemento);
            this.gcCor.Controls.Add(this.mtbCelular);
            this.gcCor.Controls.Add(this.lbCelular);
            this.gcCor.Controls.Add(this.mtbTelefone);
            this.gcCor.Controls.Add(this.lcTelefone);
            this.gcCor.Controls.Add(this.tbBairro);
            this.gcCor.Controls.Add(this.lbBairro);
            this.gcCor.Controls.Add(this.tbNumero);
            this.gcCor.Controls.Add(this.lbNumero);
            this.gcCor.Controls.Add(this.tbEndereco);
            this.gcCor.Controls.Add(this.lbEndereco);
            this.gcCor.Controls.Add(this.mtbCEP);
            this.gcCor.Controls.Add(this.lbCEP);
            this.gcCor.Controls.Add(this.cbCidade);
            this.gcCor.Controls.Add(this.lbCidade);
            this.gcCor.Controls.Add(this.tbRG_IncricaoEstadual);
            this.gcCor.Controls.Add(this.lbRG_IncricaoEstadual);
            this.gcCor.Controls.Add(this.tbApelido_Fantasia);
            this.gcCor.Controls.Add(this.lbApelido_Fantasia);
            this.gcCor.Controls.Add(this.mtbCPF_CNPJ);
            this.gcCor.Controls.Add(this.lbCPF_CNPJ);
            this.gcCor.Controls.Add(this.gbTipo);
            this.gcCor.Controls.Add(this.tbIDPessoa);
            this.gcCor.Controls.Add(this.tbNomeRazaoSocial);
            this.gcCor.Controls.Add(this.lbNomeRazaoSocial);
            this.gcCor.Controls.Add(this.bCancelar);
            this.gcCor.Controls.Add(this.cbStatus);
            this.gcCor.Controls.Add(this.lbIDPessoa);
            this.gcCor.Controls.Add(this.bGravar);
            this.gcCor.Location = new System.Drawing.Point(0, 0);
            this.gcCor.Name = "gcCor";
            this.gcCor.Size = new System.Drawing.Size(560, 259);
            this.gcCor.TabIndex = 1;
            this.gcCor.TabStop = false;
            this.gcCor.Text = "Informe os dados do cadastro";
            // 
            // cbUF
            // 
            this.cbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(10, 113);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(42, 21);
            this.cbUF.TabIndex = 13;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.ForeColor = System.Drawing.Color.Black;
            this.lbUF.Location = new System.Drawing.Point(10, 100);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(21, 13);
            this.lbUF.TabIndex = 12;
            this.lbUF.Text = "UF";
            // 
            // bCadastrarCidade
            // 
            this.bCadastrarCidade.Location = new System.Drawing.Point(191, 113);
            this.bCadastrarCidade.Name = "bCadastrarCidade";
            this.bCadastrarCidade.Size = new System.Drawing.Size(24, 21);
            this.bCadastrarCidade.TabIndex = 16;
            this.bCadastrarCidade.Text = "+";
            this.bCadastrarCidade.UseVisualStyleBackColor = true;
            this.bCadastrarCidade.Click += new System.EventHandler(this.bCadastrarCidade_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(10, 196);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(252, 20);
            this.tbEmail.TabIndex = 32;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(10, 183);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 13);
            this.lbEmail.TabIndex = 31;
            this.lbEmail.Text = "E-Mail";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(221, 155);
            this.tbComplemento.MaxLength = 100;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(138, 20);
            this.tbComplemento.TabIndex = 26;
            // 
            // lcComplemento
            // 
            this.lcComplemento.AutoSize = true;
            this.lcComplemento.ForeColor = System.Drawing.Color.Black;
            this.lcComplemento.Location = new System.Drawing.Point(221, 142);
            this.lcComplemento.Name = "lcComplemento";
            this.lcComplemento.Size = new System.Drawing.Size(71, 13);
            this.lcComplemento.TabIndex = 25;
            this.lcComplemento.Text = "Complemento";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(462, 155);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(89, 20);
            this.mtbCelular.TabIndex = 30;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.ForeColor = System.Drawing.Color.Black;
            this.lbCelular.Location = new System.Drawing.Point(462, 142);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 29;
            this.lbCelular.Text = "Celular";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(367, 155);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(87, 20);
            this.mtbTelefone.TabIndex = 28;
            // 
            // lcTelefone
            // 
            this.lcTelefone.AutoSize = true;
            this.lcTelefone.ForeColor = System.Drawing.Color.Black;
            this.lcTelefone.Location = new System.Drawing.Point(367, 142);
            this.lcTelefone.Name = "lcTelefone";
            this.lcTelefone.Size = new System.Drawing.Size(49, 13);
            this.lcTelefone.TabIndex = 27;
            this.lcTelefone.Text = "Telefone";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(10, 155);
            this.tbBairro.MaxLength = 100;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(203, 20);
            this.tbBairro.TabIndex = 24;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.ForeColor = System.Drawing.Color.Black;
            this.lbBairro.Location = new System.Drawing.Point(10, 142);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 23;
            this.lbBairro.Text = "Bairro";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(499, 113);
            this.tbNumero.MaxLength = 100;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(52, 20);
            this.tbNumero.TabIndex = 22;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.ForeColor = System.Drawing.Color.Black;
            this.lbNumero.Location = new System.Drawing.Point(497, 100);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 21;
            this.lbNumero.Text = "Número";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(301, 113);
            this.tbEndereco.MaxLength = 100;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(190, 20);
            this.tbEndereco.TabIndex = 20;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.ForeColor = System.Drawing.Color.Black;
            this.lbEndereco.Location = new System.Drawing.Point(301, 100);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 19;
            this.lbEndereco.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(223, 113);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(70, 20);
            this.mtbCEP.TabIndex = 18;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.ForeColor = System.Drawing.Color.Black;
            this.lbCEP.Location = new System.Drawing.Point(221, 100);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 13);
            this.lbCEP.TabIndex = 17;
            this.lbCEP.Text = "CEP";
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Location = new System.Drawing.Point(60, 113);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(113, 21);
            this.cbCidade.TabIndex = 15;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.ForeColor = System.Drawing.Color.Red;
            this.lbCidade.Location = new System.Drawing.Point(60, 100);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 14;
            this.lbCidade.Text = "Cidade";
            // 
            // tbRG_IncricaoEstadual
            // 
            this.tbRG_IncricaoEstadual.Location = new System.Drawing.Point(444, 31);
            this.tbRG_IncricaoEstadual.MaxLength = 100;
            this.tbRG_IncricaoEstadual.Name = "tbRG_IncricaoEstadual";
            this.tbRG_IncricaoEstadual.Size = new System.Drawing.Size(107, 20);
            this.tbRG_IncricaoEstadual.TabIndex = 7;
            // 
            // lbRG_IncricaoEstadual
            // 
            this.lbRG_IncricaoEstadual.AutoSize = true;
            this.lbRG_IncricaoEstadual.ForeColor = System.Drawing.Color.Black;
            this.lbRG_IncricaoEstadual.Location = new System.Drawing.Point(444, 18);
            this.lbRG_IncricaoEstadual.Name = "lbRG_IncricaoEstadual";
            this.lbRG_IncricaoEstadual.Size = new System.Drawing.Size(23, 13);
            this.lbRG_IncricaoEstadual.TabIndex = 6;
            this.lbRG_IncricaoEstadual.Text = "RG";
            // 
            // tbApelido_Fantasia
            // 
            this.tbApelido_Fantasia.Location = new System.Drawing.Point(301, 72);
            this.tbApelido_Fantasia.MaxLength = 100;
            this.tbApelido_Fantasia.Name = "tbApelido_Fantasia";
            this.tbApelido_Fantasia.Size = new System.Drawing.Size(250, 20);
            this.tbApelido_Fantasia.TabIndex = 11;
            // 
            // lbApelido_Fantasia
            // 
            this.lbApelido_Fantasia.AutoSize = true;
            this.lbApelido_Fantasia.ForeColor = System.Drawing.Color.Black;
            this.lbApelido_Fantasia.Location = new System.Drawing.Point(301, 59);
            this.lbApelido_Fantasia.Name = "lbApelido_Fantasia";
            this.lbApelido_Fantasia.Size = new System.Drawing.Size(42, 13);
            this.lbApelido_Fantasia.TabIndex = 10;
            this.lbApelido_Fantasia.Text = "Apelido";
            // 
            // mtbCPF_CNPJ
            // 
            this.mtbCPF_CNPJ.Location = new System.Drawing.Point(301, 31);
            this.mtbCPF_CNPJ.Name = "mtbCPF_CNPJ";
            this.mtbCPF_CNPJ.Size = new System.Drawing.Size(121, 20);
            this.mtbCPF_CNPJ.TabIndex = 5;
            // 
            // lbCPF_CNPJ
            // 
            this.lbCPF_CNPJ.AutoSize = true;
            this.lbCPF_CNPJ.ForeColor = System.Drawing.Color.Red;
            this.lbCPF_CNPJ.Location = new System.Drawing.Point(301, 17);
            this.lbCPF_CNPJ.Name = "lbCPF_CNPJ";
            this.lbCPF_CNPJ.Size = new System.Drawing.Size(27, 13);
            this.lbCPF_CNPJ.TabIndex = 4;
            this.lbCPF_CNPJ.Text = "CPF";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbJuridica);
            this.gbTipo.Controls.Add(this.rbFisica);
            this.gbTipo.Location = new System.Drawing.Point(125, 20);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(166, 33);
            this.gbTipo.TabIndex = 3;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbJuridica
            // 
            this.rbJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(97, 12);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(61, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(10, 12);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(52, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // tbIDPessoa
            // 
            this.tbIDPessoa.Location = new System.Drawing.Point(10, 31);
            this.tbIDPessoa.Name = "tbIDPessoa";
            this.tbIDPessoa.ReadOnly = true;
            this.tbIDPessoa.Size = new System.Drawing.Size(47, 20);
            this.tbIDPessoa.TabIndex = 1;
            this.tbIDPessoa.TabStop = false;
            // 
            // tbNomeRazaoSocial
            // 
            this.tbNomeRazaoSocial.Location = new System.Drawing.Point(10, 72);
            this.tbNomeRazaoSocial.MaxLength = 100;
            this.tbNomeRazaoSocial.Name = "tbNomeRazaoSocial";
            this.tbNomeRazaoSocial.Size = new System.Drawing.Size(265, 20);
            this.tbNomeRazaoSocial.TabIndex = 9;
            // 
            // lbNomeRazaoSocial
            // 
            this.lbNomeRazaoSocial.AutoSize = true;
            this.lbNomeRazaoSocial.ForeColor = System.Drawing.Color.Red;
            this.lbNomeRazaoSocial.Location = new System.Drawing.Point(10, 59);
            this.lbNomeRazaoSocial.Name = "lbNomeRazaoSocial";
            this.lbNomeRazaoSocial.Size = new System.Drawing.Size(35, 13);
            this.lbNomeRazaoSocial.TabIndex = 8;
            this.lbNomeRazaoSocial.Text = "Nome";
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancelar.Location = new System.Drawing.Point(93, 226);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 34;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(66, 34);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(50, 17);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.TabStop = false;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbIDPessoa
            // 
            this.lbIDPessoa.AutoSize = true;
            this.lbIDPessoa.Location = new System.Drawing.Point(10, 18);
            this.lbIDPessoa.Name = "lbIDPessoa";
            this.lbIDPessoa.Size = new System.Drawing.Size(40, 13);
            this.lbIDPessoa.TabIndex = 0;
            this.lbIDPessoa.Text = "Código";
            // 
            // bGravar
            // 
            this.bGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGravar.Location = new System.Drawing.Point(10, 226);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(75, 23);
            this.bGravar.TabIndex = 33;
            this.bGravar.Text = "&Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // Validacao
            // 
            this.Validacao.ContainerControl = this;
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 258);
            this.Controls.Add(this.gcCor);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(576, 297);
            this.Name = "FormCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroPessoa_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroPessoa_KeyDown);
            this.gcCor.ResumeLayout(false);
            this.gcCor.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gcCor;
        internal System.Windows.Forms.ComboBox cbUF;
        internal System.Windows.Forms.Label lbUF;
        internal System.Windows.Forms.Button bCadastrarCidade;
        internal System.Windows.Forms.TextBox tbEmail;
        internal System.Windows.Forms.Label lbEmail;
        internal System.Windows.Forms.TextBox tbComplemento;
        internal System.Windows.Forms.Label lcComplemento;
        internal System.Windows.Forms.MaskedTextBox mtbCelular;
        internal System.Windows.Forms.Label lbCelular;
        internal System.Windows.Forms.MaskedTextBox mtbTelefone;
        internal System.Windows.Forms.Label lcTelefone;
        internal System.Windows.Forms.TextBox tbBairro;
        internal System.Windows.Forms.Label lbBairro;
        internal System.Windows.Forms.TextBox tbNumero;
        internal System.Windows.Forms.Label lbNumero;
        internal System.Windows.Forms.TextBox tbEndereco;
        internal System.Windows.Forms.Label lbEndereco;
        internal System.Windows.Forms.MaskedTextBox mtbCEP;
        internal System.Windows.Forms.Label lbCEP;
        internal System.Windows.Forms.ComboBox cbCidade;
        internal System.Windows.Forms.Label lbCidade;
        internal System.Windows.Forms.TextBox tbRG_IncricaoEstadual;
        internal System.Windows.Forms.Label lbRG_IncricaoEstadual;
        internal System.Windows.Forms.TextBox tbApelido_Fantasia;
        internal System.Windows.Forms.Label lbApelido_Fantasia;
        internal System.Windows.Forms.MaskedTextBox mtbCPF_CNPJ;
        internal System.Windows.Forms.Label lbCPF_CNPJ;
        internal System.Windows.Forms.GroupBox gbTipo;
        internal System.Windows.Forms.RadioButton rbJuridica;
        internal System.Windows.Forms.RadioButton rbFisica;
        internal System.Windows.Forms.TextBox tbIDPessoa;
        internal System.Windows.Forms.TextBox tbNomeRazaoSocial;
        internal System.Windows.Forms.Label lbNomeRazaoSocial;
        internal System.Windows.Forms.Button bCancelar;
        internal System.Windows.Forms.CheckBox cbStatus;
        internal System.Windows.Forms.Label lbIDPessoa;
        internal System.Windows.Forms.Button bGravar;
        internal System.Windows.Forms.ErrorProvider Validacao;
    }
}