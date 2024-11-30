namespace PRJLogin
{
    partial class FRMpdf
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
            this.btnPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(76, 32);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(208, 45);
            this.btnPDF.TabIndex = 12;
            this.btnPDF.Text = "Gerar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // FRMpdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 103);
            this.Controls.Add(this.btnPDF);
            this.Name = "FRMpdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}