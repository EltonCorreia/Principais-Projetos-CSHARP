namespace PrjJogoDados
{
    partial class JogoDados
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
            this.btnDado = new System.Windows.Forms.Button();
            this.pctDado = new System.Windows.Forms.PictureBox();
            this.rdoManual = new System.Windows.Forms.RadioButton();
            this.rdoAutomatico = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctDado2 = new System.Windows.Forms.PictureBox();
            this.lbPonto = new System.Windows.Forms.ListBox();
            this.btnDado2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDado
            // 
            this.btnDado.Location = new System.Drawing.Point(12, 278);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(247, 34);
            this.btnDado.TabIndex = 0;
            this.btnDado.Text = "Sortear";
            this.btnDado.UseVisualStyleBackColor = true;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click);
            // 
            // pctDado
            // 
            this.pctDado.Location = new System.Drawing.Point(12, 12);
            this.pctDado.Name = "pctDado";
            this.pctDado.Size = new System.Drawing.Size(247, 260);
            this.pctDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado.TabIndex = 1;
            this.pctDado.TabStop = false;
            // 
            // rdoManual
            // 
            this.rdoManual.AutoSize = true;
            this.rdoManual.Location = new System.Drawing.Point(535, 278);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(60, 17);
            this.rdoManual.TabIndex = 2;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "Manual";
            this.rdoManual.UseVisualStyleBackColor = true;
            this.rdoManual.CheckedChanged += new System.EventHandler(this.rdoManual_CheckedChanged);
            // 
            // rdoAutomatico
            // 
            this.rdoAutomatico.AutoSize = true;
            this.rdoAutomatico.Location = new System.Drawing.Point(616, 278);
            this.rdoAutomatico.Name = "rdoAutomatico";
            this.rdoAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rdoAutomatico.TabIndex = 3;
            this.rdoAutomatico.TabStop = true;
            this.rdoAutomatico.Text = "Automático";
            this.rdoAutomatico.UseVisualStyleBackColor = true;
            this.rdoAutomatico.CheckedChanged += new System.EventHandler(this.rdoAutomatico_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctDado2
            // 
            this.pctDado2.Location = new System.Drawing.Point(265, 12);
            this.pctDado2.Name = "pctDado2";
            this.pctDado2.Size = new System.Drawing.Size(247, 260);
            this.pctDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado2.TabIndex = 4;
            this.pctDado2.TabStop = false;
            // 
            // lbPonto
            // 
            this.lbPonto.FormattingEnabled = true;
            this.lbPonto.Location = new System.Drawing.Point(518, 12);
            this.lbPonto.Name = "lbPonto";
            this.lbPonto.Size = new System.Drawing.Size(190, 238);
            this.lbPonto.TabIndex = 5;
            // 
            // btnDado2
            // 
            this.btnDado2.Location = new System.Drawing.Point(265, 278);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(247, 34);
            this.btnDado2.TabIndex = 6;
            this.btnDado2.Text = "Sortear";
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 101;
            // 
            // JogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 326);
            this.Controls.Add(this.btnDado2);
            this.Controls.Add(this.lbPonto);
            this.Controls.Add(this.pctDado2);
            this.Controls.Add(this.rdoAutomatico);
            this.Controls.Add(this.rdoManual);
            this.Controls.Add(this.pctDado);
            this.Controls.Add(this.btnDado);
            this.Name = "JogoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de dados";
            ((System.ComponentModel.ISupportInitialize)(this.pctDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDado;
        private System.Windows.Forms.PictureBox pctDado;
        private System.Windows.Forms.RadioButton rdoManual;
        private System.Windows.Forms.RadioButton rdoAutomatico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pctDado2;
        private System.Windows.Forms.ListBox lbPonto;
        private System.Windows.Forms.Button btnDado2;
        private System.Windows.Forms.Timer timer2;
    }
}

