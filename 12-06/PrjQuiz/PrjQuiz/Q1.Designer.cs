namespace PrjQuiz
{
    partial class Q1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdrbtn1 = new System.Windows.Forms.RadioButton();
            this.rdrbtn3 = new System.Windows.Forms.RadioButton();
            this.rdrbtn4 = new System.Windows.Forms.RadioButton();
            this.rdrbtn2 = new System.Windows.Forms.RadioButton();
            this.btnverificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Em que ano a banda \"Paramore\" lançou seu primeiro álbum \"All We Know Is Falling\"?" +
    "";
            // 
            // rdrbtn1
            // 
            this.rdrbtn1.AutoSize = true;
            this.rdrbtn1.Location = new System.Drawing.Point(43, 48);
            this.rdrbtn1.Name = "rdrbtn1";
            this.rdrbtn1.Size = new System.Drawing.Size(49, 17);
            this.rdrbtn1.TabIndex = 1;
            this.rdrbtn1.TabStop = true;
            this.rdrbtn1.Text = "2000";
            this.rdrbtn1.UseVisualStyleBackColor = true;
            // 
            // rdrbtn3
            // 
            this.rdrbtn3.AutoSize = true;
            this.rdrbtn3.Location = new System.Drawing.Point(150, 48);
            this.rdrbtn3.Name = "rdrbtn3";
            this.rdrbtn3.Size = new System.Drawing.Size(49, 17);
            this.rdrbtn3.TabIndex = 2;
            this.rdrbtn3.TabStop = true;
            this.rdrbtn3.Text = "2003";
            this.rdrbtn3.UseVisualStyleBackColor = true;
            // 
            // rdrbtn4
            // 
            this.rdrbtn4.AutoSize = true;
            this.rdrbtn4.Location = new System.Drawing.Point(205, 48);
            this.rdrbtn4.Name = "rdrbtn4";
            this.rdrbtn4.Size = new System.Drawing.Size(49, 17);
            this.rdrbtn4.TabIndex = 4;
            this.rdrbtn4.TabStop = true;
            this.rdrbtn4.Text = "2005";
            this.rdrbtn4.UseVisualStyleBackColor = true;
            // 
            // rdrbtn2
            // 
            this.rdrbtn2.AutoSize = true;
            this.rdrbtn2.Location = new System.Drawing.Point(98, 48);
            this.rdrbtn2.Name = "rdrbtn2";
            this.rdrbtn2.Size = new System.Drawing.Size(49, 17);
            this.rdrbtn2.TabIndex = 3;
            this.rdrbtn2.TabStop = true;
            this.rdrbtn2.Text = "2007";
            this.rdrbtn2.UseVisualStyleBackColor = true;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(295, 45);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(118, 28);
            this.btnverificar.TabIndex = 5;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 91);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.rdrbtn4);
            this.Controls.Add(this.rdrbtn2);
            this.Controls.Add(this.rdrbtn3);
            this.Controls.Add(this.rdrbtn1);
            this.Controls.Add(this.label1);
            this.Name = "Q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdrbtn1;
        private System.Windows.Forms.RadioButton rdrbtn3;
        private System.Windows.Forms.RadioButton rdrbtn4;
        private System.Windows.Forms.RadioButton rdrbtn2;
        private System.Windows.Forms.Button btnverificar;
    }
}

