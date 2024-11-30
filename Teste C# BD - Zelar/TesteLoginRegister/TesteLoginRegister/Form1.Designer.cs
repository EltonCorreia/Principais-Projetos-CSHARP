namespace TesteLoginRegister
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(13, 30);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(293, 20);
            this.txtLoginUser.TabIndex = 1;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(13, 74);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(293, 20);
            this.txtLoginSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.Location = new System.Drawing.Point(99, 100);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(77, 34);
            this.btnLoginRegister.TabIndex = 5;
            this.btnLoginRegister.Text = "Registrar";
            this.btnLoginRegister.UseVisualStyleBackColor = true;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 146);
            this.Controls.Add(this.btnLoginRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginRegister;
    }
}

