namespace PrjAula2
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkCaixa3 = new System.Windows.Forms.CheckBox();
            this.chkCaixa2 = new System.Windows.Forms.CheckBox();
            this.chkCaixa1 = new System.Windows.Forms.CheckBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(16, 334);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 26);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTexto2);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.txtTexto);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 189);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkCaixa3);
            this.panel2.Controls.Add(this.chkCaixa2);
            this.panel2.Controls.Add(this.chkCaixa1);
            this.panel2.Location = new System.Drawing.Point(16, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 109);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chkCaixa3
            // 
            this.chkCaixa3.AutoSize = true;
            this.chkCaixa3.Location = new System.Drawing.Point(26, 71);
            this.chkCaixa3.Name = "chkCaixa3";
            this.chkCaixa3.Size = new System.Drawing.Size(58, 17);
            this.chkCaixa3.TabIndex = 11;
            this.chkCaixa3.Text = "Em SP";
            this.chkCaixa3.UseVisualStyleBackColor = true;
            // 
            // chkCaixa2
            // 
            this.chkCaixa2.AutoSize = true;
            this.chkCaixa2.Location = new System.Drawing.Point(26, 48);
            this.chkCaixa2.Name = "chkCaixa2";
            this.chkCaixa2.Size = new System.Drawing.Size(57, 17);
            this.chkCaixa2.TabIndex = 10;
            this.chkCaixa2.Text = "Passei";
            this.chkCaixa2.UseVisualStyleBackColor = true;
            // 
            // chkCaixa1
            // 
            this.chkCaixa1.AutoSize = true;
            this.chkCaixa1.Location = new System.Drawing.Point(26, 25);
            this.chkCaixa1.Name = "chkCaixa1";
            this.chkCaixa1.Size = new System.Drawing.Size(74, 17);
            this.chkCaixa1.TabIndex = 9;
            this.chkCaixa1.Text = "Boa noite!\r\n";
            this.chkCaixa1.UseVisualStyleBackColor = true;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(148, 57);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(100, 20);
            this.txtTexto2.TabIndex = 9;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(125, 26);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(35, 13);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Text = "label1";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(42, 57);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(100, 20);
            this.txtTexto.TabIndex = 7;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(90, 129);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 29);
            this.btn2.TabIndex = 6;
            this.btn2.Text = ";D\r\n";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "XD\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkCaixa3;
        private System.Windows.Forms.CheckBox chkCaixa2;
        private System.Windows.Forms.CheckBox chkCaixa1;
    }
}

