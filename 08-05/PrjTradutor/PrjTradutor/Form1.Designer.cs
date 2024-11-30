namespace PrjTradutor
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
            this.txtPortugues = new System.Windows.Forms.TextBox();
            this.txtIngles = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPortugues
            // 
            this.txtPortugues.Location = new System.Drawing.Point(11, 12);
            this.txtPortugues.Name = "txtPortugues";
            this.txtPortugues.Size = new System.Drawing.Size(213, 20);
            this.txtPortugues.TabIndex = 0;
            // 
            // txtIngles
            // 
            this.txtIngles.Location = new System.Drawing.Point(11, 38);
            this.txtIngles.Name = "txtIngles";
            this.txtIngles.Size = new System.Drawing.Size(213, 20);
            this.txtIngles.TabIndex = 1;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(230, 12);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(75, 46);
            this.btnTraduzir.TabIndex = 2;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 71);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.txtIngles);
            this.Controls.Add(this.txtPortugues);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tradutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPortugues;
        private System.Windows.Forms.TextBox txtIngles;
        private System.Windows.Forms.Button btnTraduzir;
    }
}

