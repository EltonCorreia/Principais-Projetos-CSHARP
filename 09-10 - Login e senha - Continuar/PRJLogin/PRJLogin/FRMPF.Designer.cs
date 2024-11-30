namespace PRJLogin
{
    partial class FRMPF
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadastroUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cadastrar";
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadastroSenha.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(76, 247);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(327, 23);
            this.txtCadastroSenha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // txtCadastroUsuario
            // 
            this.txtCadastroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadastroUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroUsuario.Location = new System.Drawing.Point(76, 189);
            this.txtCadastroUsuario.Name = "txtCadastroUsuario";
            this.txtCadastroUsuario.Size = new System.Drawing.Size(327, 23);
            this.txtCadastroUsuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuário";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(76, 285);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(208, 45);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(290, 285);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 45);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(76, 336);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(327, 45);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(76, 130);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 23);
            this.txtID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // FRMPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(483, 425);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCadastroSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadastroUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FRMPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Física";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPF_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadastroUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}