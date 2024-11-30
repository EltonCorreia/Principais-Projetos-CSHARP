namespace _29052024
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(9, 61);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(12, 77);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(194, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 103);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 143);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btnEnviar;
    }
}

