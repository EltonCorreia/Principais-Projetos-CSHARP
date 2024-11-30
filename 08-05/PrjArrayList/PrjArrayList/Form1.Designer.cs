namespace PrjArrayList
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
            this.txtCadastrado = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCadastrado
            // 
            this.txtCadastrado.Location = new System.Drawing.Point(12, 67);
            this.txtCadastrado.Name = "txtCadastrado";
            this.txtCadastrado.Size = new System.Drawing.Size(176, 20);
            this.txtCadastrado.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 94);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(176, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Pesquisar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Cadastrados";
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(13, 41);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(35, 13);
            this.lblCadastrado.TabIndex = 3;
            this.lblCadastrado.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 139);
            this.Controls.Add(this.lblCadastrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtCadastrado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArrayList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadastrado;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastrado;
    }
}

