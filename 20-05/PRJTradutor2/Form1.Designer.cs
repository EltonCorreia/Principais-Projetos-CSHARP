namespace PRJTradutor2
{
    partial class Form1
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
            txtP = new TextBox();
            btnTraduzir = new Button();
            txtRes = new TextBox();
            SuspendLayout();
            // 
            // txtP
            // 
            txtP.Location = new Point(73, 46);
            txtP.Name = "txtP";
            txtP.Size = new Size(233, 27);
            txtP.TabIndex = 0;
            // 
            // btnTraduzir
            // 
            btnTraduzir.Location = new Point(104, 120);
            btnTraduzir.Name = "btnTraduzir";
            btnTraduzir.Size = new Size(134, 35);
            btnTraduzir.TabIndex = 2;
            btnTraduzir.Text = "Traduzir";
            btnTraduzir.UseVisualStyleBackColor = true;
            btnTraduzir.Click += btnTraduzir_Click;
            // 
            // txtRes
            // 
            txtRes.Location = new Point(73, 87);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(233, 27);
            txtRes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 322);
            Controls.Add(txtRes);
            Controls.Add(btnTraduzir);
            Controls.Add(txtP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtP;
        private Button btnTraduzir;
        private TextBox txtRes;
    }
}
