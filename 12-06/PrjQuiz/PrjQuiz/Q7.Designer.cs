namespace PrjQuiz
{
    partial class Q7
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.rdrbtn4 = new System.Windows.Forms.RadioButton();
            this.rdrbtn3 = new System.Windows.Forms.RadioButton();
            this.rdrbtn2 = new System.Windows.Forms.RadioButton();
            this.rdrbtn1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(314, 13);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(128, 80);
            this.btnVerificar.TabIndex = 11;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // rdrbtn4
            // 
            this.rdrbtn4.AutoSize = true;
            this.rdrbtn4.Location = new System.Drawing.Point(173, 73);
            this.rdrbtn4.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn4.Name = "rdrbtn4";
            this.rdrbtn4.Size = new System.Drawing.Size(113, 20);
            this.rdrbtn4.TabIndex = 10;
            this.rdrbtn4.TabStop = true;
            this.rdrbtn4.Text = "David Gilmour";
            this.rdrbtn4.UseVisualStyleBackColor = true;
            // 
            // rdrbtn3
            // 
            this.rdrbtn3.AutoSize = true;
            this.rdrbtn3.Location = new System.Drawing.Point(15, 73);
            this.rdrbtn3.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn3.Name = "rdrbtn3";
            this.rdrbtn3.Size = new System.Drawing.Size(144, 20);
            this.rdrbtn3.TabIndex = 9;
            this.rdrbtn3.TabStop = true;
            this.rdrbtn3.Text = "Johnny Greenwood";
            this.rdrbtn3.UseVisualStyleBackColor = true;
            // 
            // rdrbtn2
            // 
            this.rdrbtn2.AutoSize = true;
            this.rdrbtn2.Location = new System.Drawing.Point(173, 45);
            this.rdrbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn2.Name = "rdrbtn2";
            this.rdrbtn2.Size = new System.Drawing.Size(91, 20);
            this.rdrbtn2.TabIndex = 8;
            this.rdrbtn2.TabStop = true;
            this.rdrbtn2.Text = "Van Halen";
            this.rdrbtn2.UseVisualStyleBackColor = true;
            // 
            // rdrbtn1
            // 
            this.rdrbtn1.AutoSize = true;
            this.rdrbtn1.Location = new System.Drawing.Point(15, 46);
            this.rdrbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn1.Name = "rdrbtn1";
            this.rdrbtn1.Size = new System.Drawing.Size(62, 20);
            this.rdrbtn1.TabIndex = 7;
            this.rdrbtn1.TabStop = true;
            this.rdrbtn1.Text = "Slash";
            this.rdrbtn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quem é o guitarrista da banda \"Radiohead\"?";
            // 
            // Q7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdrbtn4);
            this.Controls.Add(this.rdrbtn3);
            this.Controls.Add(this.rdrbtn2);
            this.Controls.Add(this.rdrbtn1);
            this.Name = "Q7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.RadioButton rdrbtn4;
        private System.Windows.Forms.RadioButton rdrbtn3;
        private System.Windows.Forms.RadioButton rdrbtn2;
        private System.Windows.Forms.RadioButton rdrbtn1;
        private System.Windows.Forms.Label label1;
    }
}