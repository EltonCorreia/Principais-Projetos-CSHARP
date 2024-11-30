namespace _04062024_pt3
{
    partial class A3
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
            pctTakaku = new PictureBox();
            lblCaixa = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctTakaku).BeginInit();
            SuspendLayout();
            // 
            // pctTakaku
            // 
            pctTakaku.Image = Properties.Resources.hqdefault3;
            pctTakaku.Location = new Point(759, 24);
            pctTakaku.Name = "pctTakaku";
            pctTakaku.Size = new Size(273, 256);
            pctTakaku.TabIndex = 12;
            pctTakaku.TabStop = false;
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.BorderStyle = BorderStyle.FixedSingle;
            lblCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaixa.Location = new Point(68, 24);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(578, 30);
            lblCaixa.TabIndex = 11;
            lblCaixa.Text = "Que...você não vai falar nada! Acabei de me confessar seu merda!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(732, 30);
            label1.TabIndex = 13;
            label1.Text = "(Takaku-chan enfurecida pela sua resposta, saca uma arma e dispara na sua cabeça)";
            // 
            // A3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 292);
            Controls.Add(label1);
            Controls.Add(pctTakaku);
            Controls.Add(lblCaixa);
            Name = "A3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takaku-chan in love!";
            ((System.ComponentModel.ISupportInitialize)pctTakaku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctTakaku;
        private Label lblCaixa;
        private Label label1;
    }
}