namespace PRJLogin
{
    partial class FRMLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.CBMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(79, 179);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(327, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(79, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(327, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(79, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(268, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(138, 45);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // CBMostrarSenha
            // 
            this.CBMostrarSenha.AutoSize = true;
            this.CBMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBMostrarSenha.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMostrarSenha.ForeColor = System.Drawing.Color.White;
            this.CBMostrarSenha.Location = new System.Drawing.Point(79, 273);
            this.CBMostrarSenha.Name = "CBMostrarSenha";
            this.CBMostrarSenha.Size = new System.Drawing.Size(110, 21);
            this.CBMostrarSenha.TabIndex = 7;
            this.CBMostrarSenha.Text = "Mostrar senha";
            this.CBMostrarSenha.UseVisualStyleBackColor = true;
            this.CBMostrarSenha.CheckedChanged += new System.EventHandler(this.CBMostrarSenha_CheckedChanged);
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(499, 463);
            this.Controls.Add(this.CBMostrarSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FRMLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox CBMostrarSenha;
    }
}