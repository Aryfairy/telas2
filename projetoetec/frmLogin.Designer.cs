﻿
namespace projetoetec
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lnkCadastrar = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Black;
            this.pnlLogin.Controls.Add(this.lnkCadastrar);
            this.pnlLogin.Controls.Add(this.checkBox1);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.picLogo);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.lblUsuario);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Location = new System.Drawing.Point(219, 112);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(288, 310);
            this.pnlLogin.TabIndex = 0;
            // 
            // lnkCadastrar
            // 
            this.lnkCadastrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lnkCadastrar.AutoSize = true;
            this.lnkCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lnkCadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lnkCadastrar.Location = new System.Drawing.Point(116, 288);
            this.lnkCadastrar.Name = "lnkCadastrar";
            this.lnkCadastrar.Size = new System.Drawing.Size(52, 13);
            this.lnkCadastrar.TabIndex = 5;
            this.lnkCadastrar.TabStop = true;
            this.lnkCadastrar.Text = "Cadastrar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.checkBox1.Location = new System.Drawing.Point(78, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(78, 250);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(128, 29);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(71, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lblSenha.Location = new System.Drawing.Point(115, 176);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 19);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lblUsuario.Location = new System.Drawing.Point(106, 133);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(184)))), ((int)(((byte)(228)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(78, 195);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(128, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Tag = "";
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(184)))), ((int)(((byte)(228)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(78, 153);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemvindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lblBemvindo.Location = new System.Drawing.Point(40, 34);
            this.lblBemvindo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(656, 62);
            this.lblBemvindo.TabIndex = 1;
            this.lblBemvindo.Text = "Seja bem vindo(a) \r\nao Reserva de Laboratórios da Etec Jd. Ângela !";
            this.lblBemvindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBemvindo.Click += new System.EventHandler(this.lblBemvindo_Click);
            // 
            // picMudarTema
            // 
            this.picMudarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, -2);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 3;
            this.picMudarTema.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.lblBemvindo);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblBemvindo;
        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.LinkLabel lnkCadastrar;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

