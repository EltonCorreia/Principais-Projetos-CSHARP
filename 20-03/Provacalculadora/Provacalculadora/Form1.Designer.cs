namespace Provacalculadora
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
            this.btnsomar = new System.Windows.Forms.Button();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(240, 45);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(75, 23);
            this.btnsomar.TabIndex = 0;
            this.btnsomar.Text = "+";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.Location = new System.Drawing.Point(240, 74);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnsubtrair.TabIndex = 1;
            this.btnsubtrair.Text = "-";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(240, 132);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(75, 23);
            this.btndividir.TabIndex = 3;
            this.btndividir.Text = "÷";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(240, 103);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplicar.TabIndex = 2;
            this.btnmultiplicar.Text = "x";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(34, 48);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(183, 20);
            this.txtvalor1.TabIndex = 4;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(34, 89);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(183, 20);
            this.txtvalor2.TabIndex = 5;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(34, 132);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(183, 20);
            this.txtresultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o 1º valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite o 2º valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.btnsomar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

