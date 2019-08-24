namespace Pedido.BackupRestauracao
{
    partial class FormBackupRestauracao
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
            this.lbCaminhoRestauracao = new System.Windows.Forms.Label();
            this.bCaminhoRestaurar = new System.Windows.Forms.Button();
            this.tbCaminhoRestauracao = new System.Windows.Forms.TextBox();
            this.lcCaminhoBackup = new System.Windows.Forms.Label();
            this.bCaminhoBackup = new System.Windows.Forms.Button();
            this.tbCaminhoBackup = new System.Windows.Forms.TextBox();
            this.bRestaurar = new System.Windows.Forms.Button();
            this.bBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCaminhoRestauracao
            // 
            this.lbCaminhoRestauracao.AutoSize = true;
            this.lbCaminhoRestauracao.Location = new System.Drawing.Point(13, 87);
            this.lbCaminhoRestauracao.Name = "lbCaminhoRestauracao";
            this.lbCaminhoRestauracao.Size = new System.Drawing.Size(198, 13);
            this.lbCaminhoRestauracao.TabIndex = 17;
            this.lbCaminhoRestauracao.Text = "Caminho do arquivo que será restaurado";
            // 
            // bCaminhoRestaurar
            // 
            this.bCaminhoRestaurar.Location = new System.Drawing.Point(537, 99);
            this.bCaminhoRestaurar.Name = "bCaminhoRestaurar";
            this.bCaminhoRestaurar.Size = new System.Drawing.Size(191, 23);
            this.bCaminhoRestaurar.TabIndex = 16;
            this.bCaminhoRestaurar.Text = "Selecionar o arquivo para restaurar";
            this.bCaminhoRestaurar.UseVisualStyleBackColor = true;
            this.bCaminhoRestaurar.Click += new System.EventHandler(this.bCaminhoRestaurar_Click);
            // 
            // tbCaminhoRestauracao
            // 
            this.tbCaminhoRestauracao.Location = new System.Drawing.Point(13, 100);
            this.tbCaminhoRestauracao.Name = "tbCaminhoRestauracao";
            this.tbCaminhoRestauracao.Size = new System.Drawing.Size(518, 20);
            this.tbCaminhoRestauracao.TabIndex = 15;
            // 
            // lcCaminhoBackup
            // 
            this.lcCaminhoBackup.AutoSize = true;
            this.lcCaminhoBackup.Location = new System.Drawing.Point(13, 14);
            this.lcCaminhoBackup.Name = "lcCaminhoBackup";
            this.lcCaminhoBackup.Size = new System.Drawing.Size(188, 13);
            this.lcCaminhoBackup.TabIndex = 14;
            this.lcCaminhoBackup.Text = "Caminho onde será gravado o bakcup";
            // 
            // bCaminhoBackup
            // 
            this.bCaminhoBackup.Location = new System.Drawing.Point(537, 26);
            this.bCaminhoBackup.Name = "bCaminhoBackup";
            this.bCaminhoBackup.Size = new System.Drawing.Size(191, 23);
            this.bCaminhoBackup.TabIndex = 13;
            this.bCaminhoBackup.Text = "Selecionar a pasta de backup";
            this.bCaminhoBackup.UseVisualStyleBackColor = true;
            this.bCaminhoBackup.Click += new System.EventHandler(this.bCaminhoBackup_Click);
            // 
            // tbCaminhoBackup
            // 
            this.tbCaminhoBackup.Location = new System.Drawing.Point(13, 27);
            this.tbCaminhoBackup.Name = "tbCaminhoBackup";
            this.tbCaminhoBackup.Size = new System.Drawing.Size(518, 20);
            this.tbCaminhoBackup.TabIndex = 12;
            // 
            // bRestaurar
            // 
            this.bRestaurar.Location = new System.Drawing.Point(13, 126);
            this.bRestaurar.Name = "bRestaurar";
            this.bRestaurar.Size = new System.Drawing.Size(75, 23);
            this.bRestaurar.TabIndex = 11;
            this.bRestaurar.Text = "Restaurar";
            this.bRestaurar.UseVisualStyleBackColor = true;
            this.bRestaurar.Click += new System.EventHandler(this.bRestaurar_Click);
            // 
            // bBackup
            // 
            this.bBackup.Enabled = false;
            this.bBackup.Location = new System.Drawing.Point(13, 53);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 23);
            this.bBackup.TabIndex = 10;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // FormBackupRestauracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 162);
            this.Controls.Add(this.lbCaminhoRestauracao);
            this.Controls.Add(this.bCaminhoRestaurar);
            this.Controls.Add(this.tbCaminhoRestauracao);
            this.Controls.Add(this.lcCaminhoBackup);
            this.Controls.Add(this.bCaminhoBackup);
            this.Controls.Add(this.tbCaminhoBackup);
            this.Controls.Add(this.bRestaurar);
            this.Controls.Add(this.bBackup);
            this.Name = "FormBackupRestauracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restauração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbCaminhoRestauracao;
        internal System.Windows.Forms.Button bCaminhoRestaurar;
        internal System.Windows.Forms.TextBox tbCaminhoRestauracao;
        internal System.Windows.Forms.Label lcCaminhoBackup;
        internal System.Windows.Forms.Button bCaminhoBackup;
        internal System.Windows.Forms.TextBox tbCaminhoBackup;
        internal System.Windows.Forms.Button bRestaurar;
        internal System.Windows.Forms.Button bBackup;
    }
}