namespace Jokenpo
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
            this.pctVisor2 = new System.Windows.Forms.PictureBox();
            this.pctVisor1 = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblJog1 = new System.Windows.Forms.Label();
            this.lblJog2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctVisor2
            // 
            this.pctVisor2.Location = new System.Drawing.Point(221, 12);
            this.pctVisor2.Name = "pctVisor2";
            this.pctVisor2.Size = new System.Drawing.Size(207, 210);
            this.pctVisor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVisor2.TabIndex = 3;
            this.pctVisor2.TabStop = false;
            // 
            // pctVisor1
            // 
            this.pctVisor1.Location = new System.Drawing.Point(8, 12);
            this.pctVisor1.Name = "pctVisor1";
            this.pctVisor1.Size = new System.Drawing.Size(207, 210);
            this.pctVisor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVisor1.TabIndex = 0;
            this.pctVisor1.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(10, 250);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(418, 48);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblJog1
            // 
            this.lblJog1.AutoSize = true;
            this.lblJog1.Location = new System.Drawing.Point(12, 225);
            this.lblJog1.Name = "lblJog1";
            this.lblJog1.Size = new System.Drawing.Size(13, 13);
            this.lblJog1.TabIndex = 10;
            this.lblJog1.Text = "0";
            // 
            // lblJog2
            // 
            this.lblJog2.AutoSize = true;
            this.lblJog2.Location = new System.Drawing.Point(229, 225);
            this.lblJog2.Name = "lblJog2";
            this.lblJog2.Size = new System.Drawing.Size(13, 13);
            this.lblJog2.TabIndex = 11;
            this.lblJog2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.Controls.Add(this.lblJog2);
            this.Controls.Add(this.lblJog1);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pctVisor2);
            this.Controls.Add(this.pctVisor1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpô";
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVisor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVisor1;
        private System.Windows.Forms.PictureBox pctVisor2;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblJog1;
        private System.Windows.Forms.Label lblJog2;
    }
}

