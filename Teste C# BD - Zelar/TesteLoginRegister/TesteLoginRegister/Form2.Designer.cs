namespace TesteLoginRegister
{
    partial class Form2
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 100);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(77, 34);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterSenha
            // 
            this.txtRegisterSenha.Location = new System.Drawing.Point(13, 74);
            this.txtRegisterSenha.Name = "txtRegisterSenha";
            this.txtRegisterSenha.Size = new System.Drawing.Size(293, 20);
            this.txtRegisterSenha.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha";
            // 
            // txtRegisterUser
            // 
            this.txtRegisterUser.Location = new System.Drawing.Point(13, 30);
            this.txtRegisterUser.Name = "txtRegisterUser";
            this.txtRegisterUser.Size = new System.Drawing.Size(293, 20);
            this.txtRegisterUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 146);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegisterSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegisterUser);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegisterSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegisterUser;
        private System.Windows.Forms.Label label1;
    }
}