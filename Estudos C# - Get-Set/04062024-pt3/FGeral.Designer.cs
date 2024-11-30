namespace _04062024_pt3
{
    partial class FGeral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCaixa = new Label();
            pctTakaku = new PictureBox();
            rdrA1 = new RadioButton();
            rdrA2 = new RadioButton();
            rdrA3 = new RadioButton();
            btnAvançar = new Button();
            ((System.ComponentModel.ISupportInitialize)pctTakaku).BeginInit();
            SuspendLayout();
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.BorderStyle = BorderStyle.FixedSingle;
            lblCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaixa.Location = new Point(12, 20);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(761, 30);
            lblCaixa.TabIndex = 0;
            lblCaixa.Text = "S...Sabe Takechi-senpai, e...eu gostaria de te falar uma coisa a muito tempo, eu te amo!";
            // 
            // pctTakaku
            // 
            pctTakaku.BackgroundImage = Properties.Resources.hqdefault;
            pctTakaku.Location = new Point(728, 66);
            pctTakaku.Name = "pctTakaku";
            pctTakaku.Size = new Size(295, 266);
            pctTakaku.TabIndex = 1;
            pctTakaku.TabStop = false;
            // 
            // rdrA1
            // 
            rdrA1.AutoSize = true;
            rdrA1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdrA1.Location = new Point(12, 77);
            rdrA1.Name = "rdrA1";
            rdrA1.Size = new Size(517, 32);
            rdrA1.TabIndex = 2;
            rdrA1.TabStop = true;
            rdrA1.Text = "E...eu também te amo! Por favor, seja minha namorada...";
            rdrA1.UseVisualStyleBackColor = true;
            // 
            // rdrA2
            // 
            rdrA2.AutoSize = true;
            rdrA2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdrA2.Location = new Point(12, 128);
            rdrA2.Name = "rdrA2";
            rdrA2.Size = new Size(619, 32);
            rdrA2.TabIndex = 3;
            rdrA2.TabStop = true;
            rdrA2.Text = "Desculpe, eu gosto de você como uma amiga apenas Takaku-chan...";
            rdrA2.UseVisualStyleBackColor = true;
            // 
            // rdrA3
            // 
            rdrA3.AutoSize = true;
            rdrA3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdrA3.Location = new Point(12, 179);
            rdrA3.Name = "rdrA3";
            rdrA3.Size = new Size(141, 32);
            rdrA3.TabIndex = 4;
            rdrA3.TabStop = true;
            rdrA3.Text = "Ah, tá bom...";
            rdrA3.UseVisualStyleBackColor = true;
            // 
            // btnAvançar
            // 
            btnAvançar.Location = new Point(626, 66);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(96, 145);
            btnAvançar.TabIndex = 5;
            btnAvançar.Text = "Avançar";
            btnAvançar.UseVisualStyleBackColor = true;
            btnAvançar.Click += btnAvançar_Click;
            // 
            // FGeral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 357);
            Controls.Add(btnAvançar);
            Controls.Add(rdrA3);
            Controls.Add(rdrA2);
            Controls.Add(rdrA1);
            Controls.Add(pctTakaku);
            Controls.Add(lblCaixa);
            Name = "FGeral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takaku-chan in love!";
            ((System.ComponentModel.ISupportInitialize)pctTakaku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaixa;
        private PictureBox pctTakaku;
        private RadioButton rdrA1;
        private RadioButton rdrA2;
        private RadioButton rdrA3;
        private Button btnAvançar;
    }
}
