namespace TradutorArrayList
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(9, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(223, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(8, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(223, 20);
            this.txt2.TabIndex = 1;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(239, 12);
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
            this.ClientSize = new System.Drawing.Size(326, 74);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tradutor Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnTraduzir;
    }
}

