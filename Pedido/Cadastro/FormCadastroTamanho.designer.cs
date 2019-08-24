﻿namespace Pedido.Cadastro
{
    partial class FormCadastroTamanho
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
            this.tbIDTamanho = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.bGravar = new System.Windows.Forms.Button();
            this.lDescricao = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lIDTamanho = new System.Windows.Forms.Label();
            this.Validacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.gcCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCor
            // 
            this.gcCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcCor.Controls.Add(this.tbIDTamanho);
            this.gcCor.Controls.Add(this.tbDescricao);
            this.gcCor.Controls.Add(this.bGravar);
            this.gcCor.Controls.Add(this.lDescricao);
            this.gcCor.Controls.Add(this.bCancelar);
            this.gcCor.Controls.Add(this.cbStatus);
            this.gcCor.Controls.Add(this.lIDTamanho);
            this.gcCor.Location = new System.Drawing.Point(4, 1);
            this.gcCor.Name = "gcCor";
            this.gcCor.Size = new System.Drawing.Size(283, 96);
            this.gcCor.TabIndex = 1;
            this.gcCor.TabStop = false;
            this.gcCor.Text = "Informe os dados do cadastro";
            // 
            // tbIDTamanho
            // 
            this.tbIDTamanho.Location = new System.Drawing.Point(10, 31);
            this.tbIDTamanho.Name = "tbIDTamanho";
            this.tbIDTamanho.ReadOnly = true;
            this.tbIDTamanho.Size = new System.Drawing.Size(47, 20);
            this.tbIDTamanho.TabIndex = 1;
            this.tbIDTamanho.TabStop = false;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(117, 30);
            this.tbDescricao.MaxLength = 200;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(146, 20);
            this.tbDescricao.TabIndex = 4;
            // 
            // bGravar
            // 
            this.bGravar.Location = new System.Drawing.Point(10, 59);
            this.bGravar.Name = "bGravar";
            this.bGravar.Size = new System.Drawing.Size(75, 23);
            this.bGravar.TabIndex = 5;
            this.bGravar.Text = "&Gravar";
            this.bGravar.UseVisualStyleBackColor = true;
            this.bGravar.Click += new System.EventHandler(this.bGravar_Click);
            // 
            // lDescricao
            // 
            this.lDescricao.AutoSize = true;
            this.lDescricao.ForeColor = System.Drawing.Color.Red;
            this.lDescricao.Location = new System.Drawing.Point(117, 17);
            this.lDescricao.Name = "lDescricao";
            this.lDescricao.Size = new System.Drawing.Size(55, 13);
            this.lDescricao.TabIndex = 3;
            this.lDescricao.Text = "Descrição";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(93, 59);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
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
            // lIDTamanho
            // 
            this.lIDTamanho.AutoSize = true;
            this.lIDTamanho.Location = new System.Drawing.Point(10, 18);
            this.lIDTamanho.Name = "lIDTamanho";
            this.lIDTamanho.Size = new System.Drawing.Size(40, 13);
            this.lIDTamanho.TabIndex = 0;
            this.lIDTamanho.Text = "Código";
            // 
            // Validacao
            // 
            this.Validacao.ContainerControl = this;
            // 
            // FormCadastroTamanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 99);
            this.Controls.Add(this.gcCor);
            this.KeyPreview = true;
            this.Name = "FormCadastroTamanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de tamanho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroTamanho_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroTamanho_KeyDown);
            this.gcCor.ResumeLayout(false);
            this.gcCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gcCor;
        internal System.Windows.Forms.TextBox tbIDTamanho;
        internal System.Windows.Forms.TextBox tbDescricao;
        internal System.Windows.Forms.Button bGravar;
        internal System.Windows.Forms.Label lDescricao;
        internal System.Windows.Forms.Button bCancelar;
        internal System.Windows.Forms.CheckBox cbStatus;
        internal System.Windows.Forms.Label lIDTamanho;
        internal System.Windows.Forms.ErrorProvider Validacao;
    }
}