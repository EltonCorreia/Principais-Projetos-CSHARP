namespace PrjForca
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
            this.btnSorte = new System.Windows.Forms.Button();
            this.txtResponda = new System.Windows.Forms.TextBox();
            this.pctVisor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorte
            // 
            this.btnSorte.Location = new System.Drawing.Point(12, 324);
            this.btnSorte.Name = "btnSorte";
            this.btnSorte.Size = new System.Drawing.Size(382, 33);
            this.btnSorte.TabIndex = 1;
            this.btnSorte.Text = "Sorte";
            this.btnSorte.UseVisualStyleBackColor = true;
            this.btnSorte.Click += new System.EventHandler(this.btnSorte_Click);
            // 
            // txtResponda
            // 
            this.txtResponda.Location = new System.Drawing.Point(12, 298);
            this.txtResponda.Name = "txtResponda";
            this.txtResponda.Size = new System.Drawing.Size(382, 20);
            this.txtResponda.TabIndex = 2;
            // 
            // pctVisor
            // 
            this.pctVisor.BackgroundImage = global::PrjForca.Properties.Resources.forca;
            this.pctVisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctVisor.Location = new System.Drawing.Point(12, 12);
            this.pctVisor.Name = "pctVisor";
            this.pctVisor.Size = new System.Drawing.Size(382, 280);
            this.pctVisor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVisor.TabIndex = 0;
            this.pctVisor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 369);
            this.Controls.Add(this.txtResponda);
            this.Controls.Add(this.btnSorte);
            this.Controls.Add(this.pctVisor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da forca";
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVisor;
        private System.Windows.Forms.Button btnSorte;
        private System.Windows.Forms.TextBox txtResponda;
    }
}

