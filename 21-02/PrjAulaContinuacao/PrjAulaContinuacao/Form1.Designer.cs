namespace PrjAulaContinuacao
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
            this.lstTexto = new System.Windows.Forms.ListBox();
            this.btnCarregarlist = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbTexto = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstTexto
            // 
            this.lstTexto.FormattingEnabled = true;
            this.lstTexto.Location = new System.Drawing.Point(16, 38);
            this.lstTexto.Name = "lstTexto";
            this.lstTexto.Size = new System.Drawing.Size(273, 95);
            this.lstTexto.TabIndex = 0;
            // 
            // btnCarregarlist
            // 
            this.btnCarregarlist.Location = new System.Drawing.Point(16, 150);
            this.btnCarregarlist.Name = "btnCarregarlist";
            this.btnCarregarlist.Size = new System.Drawing.Size(104, 26);
            this.btnCarregarlist.TabIndex = 1;
            this.btnCarregarlist.Text = "Carregar list";
            this.btnCarregarlist.UseVisualStyleBackColor = true;
            this.btnCarregarlist.Click += new System.EventHandler(this.btnCarregarlist_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(178, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(111, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(159, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Digite o número a ser calculado:\r\n";
            // 
            // cmbTexto
            // 
            this.cmbTexto.FormattingEnabled = true;
            this.cmbTexto.Location = new System.Drawing.Point(321, 38);
            this.cmbTexto.Name = "cmbTexto";
            this.cmbTexto.Size = new System.Drawing.Size(291, 21);
            this.cmbTexto.TabIndex = 4;
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
            this.ClientSize = new System.Drawing.Size(633, 369);
            this.Controls.Add(this.cmbTexto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCarregarlist);
            this.Controls.Add(this.lstTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTexto;
        private System.Windows.Forms.Button btnCarregarlist;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbTexto;
        private System.Windows.Forms.Timer timer1;
    }
}

