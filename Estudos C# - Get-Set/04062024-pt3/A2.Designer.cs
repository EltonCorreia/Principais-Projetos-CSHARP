namespace _04062024_pt3
{
    partial class A2
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
            label1 = new Label();
            pctTakaku = new PictureBox();
            lblCaixa = new Label();
            ((System.ComponentModel.ISupportInitialize)pctTakaku).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 111);
            label1.Name = "label1";
            label1.Size = new Size(693, 30);
            label1.TabIndex = 11;
            label1.Text = "(Após terminarem colegial, Takechi-senpai e Takaku-chan nunca mais se viram)";
            // 
            // pctTakaku
            // 
            pctTakaku.Image = Properties.Resources.hqdefault1;
            pctTakaku.Location = new Point(782, 24);
            pctTakaku.Name = "pctTakaku";
            pctTakaku.Size = new Size(241, 241);
            pctTakaku.TabIndex = 10;
            pctTakaku.TabStop = false;
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.BorderStyle = BorderStyle.FixedSingle;
            lblCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaixa.Location = new Point(64, 24);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(650, 30);
            lblCaixa.TabIndex = 9;
            lblCaixa.Text = "Ah...Tudo bem, entendo Senpai. Vamos ser bons amigos daqui pra frente!";
            // 
            // A2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 277);
            Controls.Add(label1);
            Controls.Add(pctTakaku);
            Controls.Add(lblCaixa);
            Name = "A2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takaku-chan in love!";
            ((System.ComponentModel.ISupportInitialize)pctTakaku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pctTakaku;
        private Label lblCaixa;
    }
}