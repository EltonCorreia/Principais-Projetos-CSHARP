namespace PrjQuiz
{
    partial class Q3
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdrbtn1 = new System.Windows.Forms.RadioButton();
            this.rdrbtn2 = new System.Windows.Forms.RadioButton();
            this.rdrbtn3 = new System.Windows.Forms.RadioButton();
            this.rdrbtn4 = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual o nome da vocalista da banda \"Slowdive\"?";
            // 
            // rdrbtn1
            // 
            this.rdrbtn1.AutoSize = true;
            this.rdrbtn1.Location = new System.Drawing.Point(12, 35);
            this.rdrbtn1.Name = "rdrbtn1";
            this.rdrbtn1.Size = new System.Drawing.Size(80, 17);
            this.rdrbtn1.TabIndex = 1;
            this.rdrbtn1.TabStop = true;
            this.rdrbtn1.Text = "Tina Turner";
            this.rdrbtn1.UseVisualStyleBackColor = true;
            // 
            // rdrbtn2
            // 
            this.rdrbtn2.AutoSize = true;
            this.rdrbtn2.Location = new System.Drawing.Point(12, 58);
            this.rdrbtn2.Name = "rdrbtn2";
            this.rdrbtn2.Size = new System.Drawing.Size(92, 17);
            this.rdrbtn2.TabIndex = 2;
            this.rdrbtn2.TabStop = true;
            this.rdrbtn2.Text = "Dona Summer";
            this.rdrbtn2.UseVisualStyleBackColor = true;
            // 
            // rdrbtn3
            // 
            this.rdrbtn3.AutoSize = true;
            this.rdrbtn3.Location = new System.Drawing.Point(12, 81);
            this.rdrbtn3.Name = "rdrbtn3";
            this.rdrbtn3.Size = new System.Drawing.Size(111, 17);
            this.rdrbtn3.TabIndex = 3;
            this.rdrbtn3.TabStop = true;
            this.rdrbtn3.Text = "Dolores O\'Riordan";
            this.rdrbtn3.UseVisualStyleBackColor = true;
            // 
            // rdrbtn4
            // 
            this.rdrbtn4.AutoSize = true;
            this.rdrbtn4.Location = new System.Drawing.Point(12, 104);
            this.rdrbtn4.Name = "rdrbtn4";
            this.rdrbtn4.Size = new System.Drawing.Size(99, 17);
            this.rdrbtn4.TabIndex = 4;
            this.rdrbtn4.TabStop = true;
            this.rdrbtn4.Text = "Rachel Goswell";
            this.rdrbtn4.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(129, 35);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 86);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 138);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdrbtn4);
            this.Controls.Add(this.rdrbtn3);
            this.Controls.Add(this.rdrbtn2);
            this.Controls.Add(this.rdrbtn1);
            this.Controls.Add(this.label1);
            this.Name = "Q3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdrbtn1;
        private System.Windows.Forms.RadioButton rdrbtn2;
        private System.Windows.Forms.RadioButton rdrbtn3;
        private System.Windows.Forms.RadioButton rdrbtn4;
        private System.Windows.Forms.Button btnVerificar;
    }
}