namespace PrjCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoSomar = new System.Windows.Forms.RadioButton();
            this.rdoSubtrair = new System.Windows.Forms.RadioButton();
            this.rdoMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdoDivisao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(32, 75);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(273, 22);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(32, 153);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(273, 22);
            this.txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o segundo valor:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(329, 75);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(199, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(384, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // rdoSomar
            // 
            this.rdoSomar.AutoSize = true;
            this.rdoSomar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoSomar.Location = new System.Drawing.Point(33, 254);
            this.rdoSomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSomar.Name = "rdoSomar";
            this.rdoSomar.Size = new System.Drawing.Size(68, 20);
            this.rdoSomar.TabIndex = 13;
            this.rdoSomar.TabStop = true;
            this.rdoSomar.Text = "Somar";
            this.rdoSomar.UseVisualStyleBackColor = true;
            // 
            // rdoSubtrair
            // 
            this.rdoSubtrair.AutoSize = true;
            this.rdoSubtrair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoSubtrair.Location = new System.Drawing.Point(33, 282);
            this.rdoSubtrair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSubtrair.Name = "rdoSubtrair";
            this.rdoSubtrair.Size = new System.Drawing.Size(74, 20);
            this.rdoSubtrair.TabIndex = 14;
            this.rdoSubtrair.TabStop = true;
            this.rdoSubtrair.Text = "Subtrair";
            this.rdoSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdoMultiplicar
            // 
            this.rdoMultiplicar.AutoSize = true;
            this.rdoMultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoMultiplicar.Location = new System.Drawing.Point(33, 310);
            this.rdoMultiplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMultiplicar.Name = "rdoMultiplicar";
            this.rdoMultiplicar.Size = new System.Drawing.Size(88, 20);
            this.rdoMultiplicar.TabIndex = 15;
            this.rdoMultiplicar.TabStop = true;
            this.rdoMultiplicar.Text = "Multiplicar";
            this.rdoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdoDivisao
            // 
            this.rdoDivisao.AutoSize = true;
            this.rdoDivisao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoDivisao.Location = new System.Drawing.Point(33, 338);
            this.rdoDivisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDivisao.Name = "rdoDivisao";
            this.rdoDivisao.Size = new System.Drawing.Size(66, 20);
            this.rdoDivisao.TabIndex = 16;
            this.rdoDivisao.TabStop = true;
            this.rdoDivisao.Text = "Dividir";
            this.rdoDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(33, 203);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(147, 28);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(571, 409);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdoDivisao);
            this.Controls.Add(this.rdoMultiplicar);
            this.Controls.Add(this.rdoSubtrair);
            this.Controls.Add(this.rdoSomar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoSomar;
        private System.Windows.Forms.RadioButton rdoSubtrair;
        private System.Windows.Forms.RadioButton rdoMultiplicar;
        private System.Windows.Forms.RadioButton rdoDivisao;
        private System.Windows.Forms.Button btnCalcular;
    }
}

