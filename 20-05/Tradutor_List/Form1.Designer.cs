namespace Tradutor_List
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
            txtport = new TextBox();
            txteng = new TextBox();
            btnTraduz = new Button();
            SuspendLayout();
            // 
            // txtport
            // 
            txtport.Location = new Point(37, 70);
            txtport.Name = "txtport";
            txtport.Size = new Size(166, 27);
            txtport.TabIndex = 0;
            // 
            // txteng
            // 
            txteng.Location = new Point(230, 70);
            txteng.Name = "txteng";
            txteng.Size = new Size(166, 27);
            txteng.TabIndex = 1;
            // 
            // btnTraduz
            // 
            btnTraduz.Location = new Point(168, 120);
            btnTraduz.Name = "btnTraduz";
            btnTraduz.Size = new Size(94, 29);
            btnTraduz.TabIndex = 2;
            btnTraduz.Text = "Traduzir";
            btnTraduz.UseVisualStyleBackColor = true;
            btnTraduz.Click += btnTraduz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 220);
            Controls.Add(btnTraduz);
            Controls.Add(txteng);
            Controls.Add(txtport);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtport;
        private TextBox txteng;
        private Button btnTraduz;
    }
}
