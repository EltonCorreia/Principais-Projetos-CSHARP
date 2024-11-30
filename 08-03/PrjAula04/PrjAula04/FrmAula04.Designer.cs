namespace PrjAula04
{
    partial class FrmAula04
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
            this.Lstprimario = new System.Windows.Forms.ListBox();
            this.Lstsecundario = new System.Windows.Forms.ListBox();
            this.BtnTransferir = new System.Windows.Forms.Button();
            this.BtnTransferirVolta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lstprimario
            // 
            this.Lstprimario.FormattingEnabled = true;
            this.Lstprimario.Location = new System.Drawing.Point(45, 62);
            this.Lstprimario.Name = "Lstprimario";
            this.Lstprimario.Size = new System.Drawing.Size(190, 121);
            this.Lstprimario.TabIndex = 0;
            // 
            // Lstsecundario
            // 
            this.Lstsecundario.FormattingEnabled = true;
            this.Lstsecundario.Location = new System.Drawing.Point(374, 62);
            this.Lstsecundario.Name = "Lstsecundario";
            this.Lstsecundario.Size = new System.Drawing.Size(190, 121);
            this.Lstsecundario.TabIndex = 1;
            // 
            // BtnTransferir
            // 
            this.BtnTransferir.Location = new System.Drawing.Point(270, 80);
            this.BtnTransferir.Name = "BtnTransferir";
            this.BtnTransferir.Size = new System.Drawing.Size(75, 23);
            this.BtnTransferir.TabIndex = 2;
            this.BtnTransferir.Text = "Transferir";
            this.BtnTransferir.UseVisualStyleBackColor = true;
            this.BtnTransferir.Click += new System.EventHandler(this.BtnTransferir_Click);
            // 
            // BtnTransferirVolta
            // 
            this.BtnTransferirVolta.Location = new System.Drawing.Point(270, 134);
            this.BtnTransferirVolta.Name = "BtnTransferirVolta";
            this.BtnTransferirVolta.Size = new System.Drawing.Size(75, 23);
            this.BtnTransferirVolta.TabIndex = 3;
            this.BtnTransferirVolta.Text = "Voltar";
            this.BtnTransferirVolta.UseVisualStyleBackColor = true;
            this.BtnTransferirVolta.Click += new System.EventHandler(this.BtnTransferirVolta_Click);
            // 
            // FrmAula04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 252);
            this.Controls.Add(this.BtnTransferirVolta);
            this.Controls.Add(this.BtnTransferir);
            this.Controls.Add(this.Lstsecundario);
            this.Controls.Add(this.Lstprimario);
            this.Name = "FrmAula04";
            this.Text = "Aula 04";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAula04_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAula04_FormClosed);
            this.Load += new System.EventHandler(this.FrmAula04_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lstprimario;
        private System.Windows.Forms.ListBox Lstsecundario;
        private System.Windows.Forms.Button BtnTransferir;
        private System.Windows.Forms.Button BtnTransferirVolta;
    }
}

