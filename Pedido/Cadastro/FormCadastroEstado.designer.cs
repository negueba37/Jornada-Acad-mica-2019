namespace Pedido.Cadastro
{
    partial class FormCadastroEstado
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
            this.lIDEstado = new System.Windows.Forms.Label();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.bGravar = new System.Windows.Forms.Button();
            this.lUF = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIDEstado = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.Validacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEstado
            // 
            this.gbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbEstado.Controls.Add(this.lIDEstado);
            this.gbEstado.Controls.Add(this.tbUF);
            this.gbEstado.Controls.Add(this.bGravar);
            this.gbEstado.Controls.Add(this.lUF);
            this.gbEstado.Controls.Add(this.bCancelar);
            this.gbEstado.Controls.Add(this.tbNome);
            this.gbEstado.Controls.Add(this.tbIDEstado);
            this.gbEstado.Controls.Add(this.lNome);
            this.gbEstado.Location = new System.Drawing.Point(12, 9);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Size = new System.Drawing.Size(264, 128);
            this.gbEstado.TabIndex = 1;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Informe os dados do cadastro";
            // 
            // lIDEstado
            // 
            this.lIDEstado.AutoSize = true;
            this.lIDEstado.Location = new System.Drawing.Point(6, 15);
            this.lIDEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIDEstado.Name = "lIDEstado";
            this.lIDEstado.Size = new System.Drawing.Size(40, 13);
            this.lIDEstado.TabIndex = 0;
            this.lIDEstado.Text = "Código";
            // 
            // tbUF
            // 
            this.tbUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUF.Location = new System.Drawing.Point(208, 70);
            this.tbUF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUF.MaxLength = 2;
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(36, 20);
            this.tbUF.TabIndex = 5;
            // 
            // bGravar
            // 
            this.bGravar.Location = new System.Drawing.Point(6, 98);
            this.bGravar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(74, 24);
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
            this.lUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUF.Name = "lUF";
            this.lUF.Size = new System.Drawing.Size(21, 13);
            this.lUF.TabIndex = 4;
            this.lUF.Text = "UF";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(88, 98);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(74, 24);
            this.bCancelar.TabIndex = 7;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(6, 70);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(178, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbIDEstado
            // 
            this.tbIDEstado.Location = new System.Drawing.Point(6, 28);
            this.tbIDEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIDEstado.Name = "tbIDEstado";
            this.tbIDEstado.ReadOnly = true;
            this.tbIDEstado.Size = new System.Drawing.Size(47, 20);
            this.tbIDEstado.TabIndex = 1;
            this.tbIDEstado.TabStop = false;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.ForeColor = System.Drawing.Color.Red;
            this.lNome.Location = new System.Drawing.Point(6, 57);
            this.lNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 2;
            this.lNome.Text = "Nome";
            // 
            // Validacao
            // 
            this.Validacao.ContainerControl = this;
            // 
            // FormCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 146);
            this.Controls.Add(this.gbEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 185);
            this.Name = "FormCadastroEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de estado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroEstado_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroEstado_KeyDown);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbEstado;
        internal System.Windows.Forms.Label lIDEstado;
        internal System.Windows.Forms.TextBox tbUF;
        internal System.Windows.Forms.Button bGravar;
        internal System.Windows.Forms.Label lUF;
        internal System.Windows.Forms.Button bCancelar;
        internal System.Windows.Forms.TextBox tbNome;
        internal System.Windows.Forms.TextBox tbIDEstado;
        internal System.Windows.Forms.Label lNome;
        internal System.Windows.Forms.ErrorProvider Validacao;
    }
}