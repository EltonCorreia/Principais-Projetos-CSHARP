namespace PrjAula03
{
    partial class FrmMicelania03
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
            this.components = new System.ComponentModel.Container();
            this.lstTexto = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTexto
            // 
            this.lstTexto.FormattingEnabled = true;
            this.lstTexto.Location = new System.Drawing.Point(23, 22);
            this.lstTexto.Name = "lstTexto";
            this.lstTexto.Size = new System.Drawing.Size(126, 147);
            this.lstTexto.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(23, 175);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(126, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(166, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(107, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(166, 109);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // FrmMicelania03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 221);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstTexto);
            this.Name = "FrmMicelania03";
            this.Text = "Micelânia";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTexto;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

