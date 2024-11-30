namespace PrjAula04Cont
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LblDia = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDia.Location = new System.Drawing.Point(101, 155);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(153, 37);
            this.LblDia.TabIndex = 0;
            this.LblDia.Text = "Domingo";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.Location = new System.Drawing.Point(93, 102);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(171, 33);
            this.LblTimer.TabIndex = 1;
            this.LblTimer.Text = "00 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 300);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.LblDia);
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

