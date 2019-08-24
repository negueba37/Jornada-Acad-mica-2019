namespace Pedido.Cadastro
{
    partial class FormCadastroUsuario
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
            this.lbIDUsuario = new System.Windows.Forms.Label();
            this.tbIDUsuario = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbConfirmacao = new System.Windows.Forms.TextBox();
            this.lbConfirmacao = new System.Windows.Forms.Label();
            this.bGravar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.validacao = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIDUsuario
            // 
            this.lbIDUsuario.AutoSize = true;
            this.lbIDUsuario.Location = new System.Drawing.Point(8, 9);
            this.lbIDUsuario.Name = "lbIDUsuario";
            this.lbIDUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbIDUsuario.TabIndex = 0;
            this.lbIDUsuario.Text = "Código";
            // 
            // tbIDUsuario
            // 
            this.tbIDUsuario.Location = new System.Drawing.Point(8, 25);
            this.tbIDUsuario.Name = "tbIDUsuario";
            this.tbIDUsuario.ReadOnly = true;
            this.tbIDUsuario.Size = new System.Drawing.Size(40, 20);
            this.tbIDUsuario.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(8, 66);
            this.tbLogin.MaxLength = 50;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(188, 20);
            this.tbLogin.TabIndex = 4;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.ForeColor = System.Drawing.Color.Red;
            this.lbLogin.Location = new System.Drawing.Point(8, 53);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(8, 107);
            this.tbSenha.MaxLength = 50;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(82, 20);
            this.tbSenha.TabIndex = 6;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.ForeColor = System.Drawing.Color.Red;
            this.lbSenha.Location = new System.Drawing.Point(8, 94);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha";
            // 
            // tbConfirmacao
            // 
            this.tbConfirmacao.Location = new System.Drawing.Point(114, 106);
            this.tbConfirmacao.MaxLength = 50;
            this.tbConfirmacao.Name = "tbConfirmacao";
            this.tbConfirmacao.PasswordChar = '*';
            this.tbConfirmacao.Size = new System.Drawing.Size(82, 20);
            this.tbConfirmacao.TabIndex = 8;
            // 
            // lbConfirmacao
            // 
            this.lbConfirmacao.AutoSize = true;
            this.lbConfirmacao.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmacao.Location = new System.Drawing.Point(114, 93);
            this.lbConfirmacao.Name = "lbConfirmacao";
            this.lbConfirmacao.Size = new System.Drawing.Size(66, 13);
            this.lbConfirmacao.TabIndex = 7;
            this.lbConfirmacao.Text = "Confirmação";
            // 
            // bGravar
            // 
            this.bGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGravar.Location = new System.Drawing.Point(10, 147);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(75, 23);
            this.bGravar.TabIndex = 9;
            this.bGravar.Text = "Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.BGravar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancelar.Location = new System.Drawing.Point(91, 147);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(54, 27);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(50, 17);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // validacao
            // 
            this.validacao.ContainerControl = this;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 182);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGravar);
            this.Controls.Add(this.tbConfirmacao);
            this.Controls.Add(this.lbConfirmacao);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbIDUsuario);
            this.Controls.Add(this.lbIDUsuario);
            this.KeyPreview = true;
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroUsuario_FormClosing);
            this.Shown += new System.EventHandler(this.FormCadastroUsuario_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDUsuario;
        private System.Windows.Forms.TextBox tbIDUsuario;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbConfirmacao;
        private System.Windows.Forms.Label lbConfirmacao;
        private System.Windows.Forms.Button bGravar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.ErrorProvider validacao;
    }
}