namespace Pedido
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btEntrar = new System.Windows.Forms.Button();
            this.epErros = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErros)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(14, 12);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(187, 187);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(219, 13);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(48, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(219, 67);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(219, 33);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(174, 26);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Text = "Charles";
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            // 
            // tbSenha
            // 
            this.tbSenha.ForeColor = System.Drawing.Color.Red;
            this.tbSenha.Location = new System.Drawing.Point(219, 87);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(174, 26);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.Text = "1";
            this.tbSenha.Enter += new System.EventHandler(this.tbSenha_Enter);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Maroon;
            this.lbMensagem.Location = new System.Drawing.Point(216, 167);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(72, 15);
            this.lbMensagem.TabIndex = 5;
            this.lbMensagem.Text = "Mensagens";
            this.lbMensagem.Visible = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btEntrar.FlatAppearance.BorderSize = 0;
            this.btEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Location = new System.Drawing.Point(219, 131);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(190, 28);
            this.btEntrar.TabIndex = 0;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // epErros
            // 
            this.epErros.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 211);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.PictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbMensagem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.ErrorProvider epErros;
    }
}