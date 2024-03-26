
namespace projetoetec
{
    partial class frmSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenha));
            this.picMudarTema = new System.Windows.Forms.PictureBox();
            this.pnlNovaSennha = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).BeginInit();
            this.pnlNovaSennha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picMudarTema
            // 
            this.picMudarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.picMudarTema.Image = ((System.Drawing.Image)(resources.GetObject("picMudarTema.Image")));
            this.picMudarTema.Location = new System.Drawing.Point(0, 0);
            this.picMudarTema.Name = "picMudarTema";
            this.picMudarTema.Size = new System.Drawing.Size(32, 32);
            this.picMudarTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMudarTema.TabIndex = 5;
            this.picMudarTema.TabStop = false;
            this.picMudarTema.Click += new System.EventHandler(this.picMudarTema_Click);
            // 
            // pnlNovaSennha
            // 
            this.pnlNovaSennha.BackColor = System.Drawing.Color.Black;
            this.pnlNovaSennha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNovaSennha.Controls.Add(this.btnConfirmar);
            this.pnlNovaSennha.Controls.Add(this.picLogo);
            this.pnlNovaSennha.Controls.Add(this.lblConfirmar);
            this.pnlNovaSennha.Controls.Add(this.lblNovaSenha);
            this.pnlNovaSennha.Controls.Add(this.txtConfirmar);
            this.pnlNovaSennha.Controls.Add(this.txtNovaSenha);
            this.pnlNovaSennha.Location = new System.Drawing.Point(228, 84);
            this.pnlNovaSennha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNovaSennha.Name = "pnlNovaSennha";
            this.pnlNovaSennha.Size = new System.Drawing.Size(288, 303);
            this.pnlNovaSennha.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(78, 261);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 29);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
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
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lblConfirmar.Location = new System.Drawing.Point(62, 192);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(162, 19);
            this.lblConfirmar.TabIndex = 1;
            this.lblConfirmar.Text = "Confirme a senha:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.lblNovaSenha.Location = new System.Drawing.Point(89, 141);
            this.lblNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(108, 19);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova senha:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(184)))), ((int)(((byte)(228)))));
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmar.Location = new System.Drawing.Point(58, 213);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmar.MaxLength = 25;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = 'l';
            this.txtConfirmar.Size = new System.Drawing.Size(171, 20);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.Tag = "";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(184)))), ((int)(((byte)(228)))));
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaSenha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(58, 162);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovaSenha.MaxLength = 25;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(171, 20);
            this.txtNovaSenha.TabIndex = 1;
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.picMudarTema);
            this.Controls.Add(this.pnlNovaSennha);
            this.Name = "frmSenha";
            this.Text = "frmSenha";
            ((System.ComponentModel.ISupportInitialize)(this.picMudarTema)).EndInit();
            this.pnlNovaSennha.ResumeLayout(false);
            this.pnlNovaSennha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMudarTema;
        private System.Windows.Forms.Panel pnlNovaSennha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtNovaSenha;
    }
}