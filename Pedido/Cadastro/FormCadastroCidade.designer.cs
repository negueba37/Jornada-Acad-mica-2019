namespace Pedido.Cadastro
{
    partial class FormCadastroCidade
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
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lIDCidade = new System.Windows.Forms.Label();
            this.bGravar = new System.Windows.Forms.Button();
            this.lUF = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIDCidade = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.Validacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstado
            // 
            this.gbEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbEstado.Controls.Add(this.cbUF);
            this.gbEstado.Controls.Add(this.lIDCidade);
            this.gbEstado.Controls.Add(this.bGravar);
            this.gbEstado.Controls.Add(this.lUF);
            this.gbEstado.Controls.Add(this.bCancelar);
            this.gbEstado.Controls.Add(this.tbNome);
            this.gbEstado.Controls.Add(this.tbIDCidade);
            this.gbEstado.Controls.Add(this.lNome);
            this.gbEstado.Location = new System.Drawing.Point(0, 0);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(283, 127);
            this.gbEstado.TabIndex = 1;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Informe os dados do cadastro";
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(208, 69);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(51, 21);
            this.cbUF.TabIndex = 5;
            // 
            // lIDCidade
            // 
            this.lIDCidade.AutoSize = true;
            this.lIDCidade.Location = new System.Drawing.Point(6, 16);
            this.lIDCidade.Name = "lIDCidade";
            this.lIDCidade.Size = new System.Drawing.Size(40, 13);
            this.lIDCidade.TabIndex = 0;
            this.lIDCidade.Text = "Código";
            // 
            // bGravar
            // 
            this.bGravar.Location = new System.Drawing.Point(6, 98);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(75, 23);
            this.bGravar.TabIndex = 6;
            this.bGravar.Text = "&Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // lUF
            // 
            this.lUF.AutoSize = true;
            this.lUF.ForeColor = System.Drawing.Color.Red;
            this.lUF.Location = new System.Drawing.Point(208, 57);
            this.lUF.Name = "lUF";
            this.lUF.Size = new System.Drawing.Size(21, 13);
            this.lUF.TabIndex = 4;
            this.lUF.Text = "UF";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(88, 98);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 7;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(6, 70);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(178, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbIDCidade
            // 
            this.tbIDCidade.Location = new System.Drawing.Point(6, 29);
            this.tbIDCidade.Name = "tbIDCidade";
            this.tbIDCidade.ReadOnly = true;
            this.tbIDCidade.Size = new System.Drawing.Size(47, 20);
            this.tbIDCidade.TabIndex = 1;
            this.tbIDCidade.TabStop = false;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.ForeColor = System.Drawing.Color.Red;
            this.lNome.Location = new System.Drawing.Point(6, 57);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 2;
            this.lNome.Text = "Nome";
            // 
            // Validacao
            // 
            this.Validacao.ContainerControl = this;
            // 
            // FormCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 126);
            this.Controls.Add(this.gbEstado);
            this.KeyPreview = true;
            this.Name = "FormCadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroCidade_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroCidade_KeyDown);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbEstado;
        internal System.Windows.Forms.ComboBox cbUF;
        internal System.Windows.Forms.Label lIDCidade;
        internal System.Windows.Forms.Button bGravar;
        internal System.Windows.Forms.Label lUF;
        internal System.Windows.Forms.Button bCancelar;
        internal System.Windows.Forms.TextBox tbNome;
        internal System.Windows.Forms.TextBox tbIDCidade;
        internal System.Windows.Forms.Label lNome;
        internal System.Windows.Forms.ErrorProvider Validacao;
    }
}