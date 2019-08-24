namespace Pedido.Pesquisa
{
    partial class FormPesquisaUsuario
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
            this.bIncluir = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbIDUsuario = new System.Windows.Forms.TextBox();
            this.lbIDUsuario = new System.Windows.Forms.Label();
            this.bFechar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bIncluir
            // 
            this.bIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bIncluir.Location = new System.Drawing.Point(6, 346);
            this.bIncluir.Name = "bIncluir";
            this.bIncluir.Size = new System.Drawing.Size(75, 23);
            this.bIncluir.TabIndex = 8;
            this.bIncluir.Text = "&Incluir";
            this.bIncluir.UseVisualStyleBackColor = true;
            this.bIncluir.Click += new System.EventHandler(this.BIncluir_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAlterar.Location = new System.Drawing.Point(87, 346);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 9;
            this.bAlterar.Text = "&Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.BAlterar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExcluir.Location = new System.Drawing.Point(168, 346);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 10;
            this.bExcluir.Text = "&Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.BExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.bPesquisar);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.tbIDUsuario);
            this.groupBox1.Controls.Add(this.lbIDUsuario);
            this.groupBox1.Controls.Add(this.bFechar);
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Controls.Add(this.bIncluir);
            this.groupBox1.Controls.Add(this.bExcluir);
            this.groupBox1.Controls.Add(this.bAlterar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe os dados para pesquisar:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            " ",
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(63, 32);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(75, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPesquisar.Location = new System.Drawing.Point(299, 30);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bPesquisar.TabIndex = 6;
            this.bPesquisar.Text = "&Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.BPesquisar_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(146, 32);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(142, 20);
            this.tbLogin.TabIndex = 5;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(146, 19);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(63, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status";
            // 
            // tbIDUsuario
            // 
            this.tbIDUsuario.Location = new System.Drawing.Point(9, 32);
            this.tbIDUsuario.Name = "tbIDUsuario";
            this.tbIDUsuario.Size = new System.Drawing.Size(46, 20);
            this.tbIDUsuario.TabIndex = 1;
            // 
            // lbIDUsuario
            // 
            this.lbIDUsuario.AutoSize = true;
            this.lbIDUsuario.Location = new System.Drawing.Point(9, 19);
            this.lbIDUsuario.Name = "lbIDUsuario";
            this.lbIDUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbIDUsuario.TabIndex = 0;
            this.lbIDUsuario.Text = "Código";
            // 
            // bFechar
            // 
            this.bFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFechar.Location = new System.Drawing.Point(299, 346);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 11;
            this.bFechar.Text = "&Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.BFechar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsuario,
            this.colStatus,
            this.colLogin});
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 59);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 5;
            this.dgvUsuarios.Size = new System.Drawing.Size(368, 281);
            this.dgvUsuarios.TabIndex = 7;
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.HeaderText = "Código";
            this.colIDUsuario.Name = "colIDUsuario";
            this.colIDUsuario.ReadOnly = true;
            this.colIDUsuario.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Ativo";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 60;
            // 
            // colLogin
            // 
            this.colLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogin.HeaderText = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.ReadOnly = true;
            this.colLogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 375);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(396, 413);
            this.Name = "FormPesquisaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de usuario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaUsuario_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIncluir;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbIDUsuario;
        private System.Windows.Forms.Label lbIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogin;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}