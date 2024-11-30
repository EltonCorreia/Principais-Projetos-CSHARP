namespace _04062024_pt3
{
    partial class A1
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
            pctTakaku.Image = Properties.Resources.hqdefault2;
            pctTakaku.Location = new Point(787, 24);
            pctTakaku.Name = "pctTakaku";
            pctTakaku.Size = new Size(250, 250);
            pctTakaku.TabIndex = 7;
            pctTakaku.TabStop = false;
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.BorderStyle = BorderStyle.FixedSingle;
            lblCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaixa.Location = new Point(23, 24);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(740, 30);
            lblCaixa.TabIndex = 6;
            lblCaixa.Text = "S...Sério...? Aí Takechi-senpai, quero sim ser sua namorada! Vamos ser felizes juntos...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 109);
            label1.Name = "label1";
            label1.Size = new Size(712, 30);
            label1.TabIndex = 8;
            label1.Text = "(Takechi-senpai e Takaku-chan ficaram juntos pra sempre até a morte, parabéns!)";
            // 
            // A1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 309);
            Controls.Add(label1);
            Controls.Add(pctTakaku);
            Controls.Add(lblCaixa);
            Name = "A1";
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