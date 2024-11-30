namespace PrjQuiz
{
    partial class Q8
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
            this.btnVerificar.Location = new System.Drawing.Point(504, 13);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(161, 60);
            this.btnVerificar.TabIndex = 17;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // rdrbtn4
            // 
            this.rdrbtn4.AutoSize = true;
            this.rdrbtn4.Location = new System.Drawing.Point(381, 48);
            this.rdrbtn4.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn4.Name = "rdrbtn4";
            this.rdrbtn4.Size = new System.Drawing.Size(91, 20);
            this.rdrbtn4.TabIndex = 16;
            this.rdrbtn4.TabStop = true;
            this.rdrbtn4.Text = "Pink Floyd";
            this.rdrbtn4.UseVisualStyleBackColor = true;
            // 
            // rdrbtn3
            // 
            this.rdrbtn3.AutoSize = true;
            this.rdrbtn3.Location = new System.Drawing.Point(236, 48);
            this.rdrbtn3.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn3.Name = "rdrbtn3";
            this.rdrbtn3.Size = new System.Drawing.Size(142, 20);
            this.rdrbtn3.TabIndex = 15;
            this.rdrbtn3.TabStop = true;
            this.rdrbtn3.Text = "The Rolling Stones";
            this.rdrbtn3.UseVisualStyleBackColor = true;
            // 
            // rdrbtn2
            // 
            this.rdrbtn2.AutoSize = true;
            this.rdrbtn2.Location = new System.Drawing.Point(121, 48);
            this.rdrbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn2.Name = "rdrbtn2";
            this.rdrbtn2.Size = new System.Drawing.Size(107, 20);
            this.rdrbtn2.TabIndex = 14;
            this.rdrbtn2.TabStop = true;
            this.rdrbtn2.Text = "Led Zeppelin";
            this.rdrbtn2.UseVisualStyleBackColor = true;
            // 
            // rdrbtn1
            // 
            this.rdrbtn1.AutoSize = true;
            this.rdrbtn1.Location = new System.Drawing.Point(18, 48);
            this.rdrbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.rdrbtn1.Name = "rdrbtn1";
            this.rdrbtn1.Size = new System.Drawing.Size(101, 20);
            this.rdrbtn1.TabIndex = 13;
            this.rdrbtn1.TabStop = true;
            this.rdrbtn1.Text = "The Beatles";
            this.rdrbtn1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Qual banda britânica lançou o álbum \"The Dark Side of the Moon\" em 1973?";
            // 
            // Q8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdrbtn4);
            this.Controls.Add(this.rdrbtn3);
            this.Controls.Add(this.rdrbtn2);
            this.Controls.Add(this.rdrbtn1);
            this.Name = "Q8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q8";
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