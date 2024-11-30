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
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(24, 61);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(206, 20);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(24, 124);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(206, 20);
            this.txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o segundo valor:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(247, 61);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(288, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // rdoSomar
            // 
            this.rdoSomar.AutoSize = true;
            this.rdoSomar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoSomar.Location = new System.Drawing.Point(25, 206);
            this.rdoSomar.Name = "rdoSomar";
            this.rdoSomar.Size = new System.Drawing.Size(55, 17);
            this.rdoSomar.TabIndex = 13;
            this.rdoSomar.TabStop = true;
            this.rdoSomar.Text = "Somar";
            this.rdoSomar.UseVisualStyleBackColor = true;
            this.rdoSomar.CheckedChanged += new System.EventHandler(this.rdoSomar_CheckedChanged);
            // 
            // rdoSubtrair
            // 
            this.rdoSubtrair.AutoSize = true;
            this.rdoSubtrair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoSubtrair.Location = new System.Drawing.Point(25, 229);
            this.rdoSubtrair.Name = "rdoSubtrair";
            this.rdoSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdoSubtrair.TabIndex = 14;
            this.rdoSubtrair.TabStop = true;
            this.rdoSubtrair.Text = "Subtrair";
            this.rdoSubtrair.UseVisualStyleBackColor = true;
            this.rdoSubtrair.CheckedChanged += new System.EventHandler(this.rdoSubtrair_CheckedChanged);
            // 
            // rdoMultiplicar
            // 
            this.rdoMultiplicar.AutoSize = true;
            this.rdoMultiplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoMultiplicar.Location = new System.Drawing.Point(25, 252);
            this.rdoMultiplicar.Name = "rdoMultiplicar";
            this.rdoMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdoMultiplicar.TabIndex = 15;
            this.rdoMultiplicar.TabStop = true;
            this.rdoMultiplicar.Text = "Multiplicar";
            this.rdoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdoDivisao
            // 
            this.rdoDivisao.AutoSize = true;
            this.rdoDivisao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoDivisao.Location = new System.Drawing.Point(25, 275);
            this.rdoDivisao.Name = "rdoDivisao";
            this.rdoDivisao.Size = new System.Drawing.Size(54, 17);
            this.rdoDivisao.TabIndex = 16;
            this.rdoDivisao.TabStop = true;
            this.rdoDivisao.Text = "Dividir";
            this.rdoDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(428, 332);
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

