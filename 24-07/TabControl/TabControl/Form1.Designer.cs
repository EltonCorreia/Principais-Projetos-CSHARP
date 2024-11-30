namespace TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.txtEnviarSobrenome = new System.Windows.Forms.TextBox();
            this.txtEnviarNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtReceberSobrenome = new System.Windows.Forms.TextBox();
            this.txtReceberNome = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 185);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEnviar);
            this.tabPage1.Controls.Add(this.txtEnviarSobrenome);
            this.tabPage1.Controls.Add(this.txtEnviarNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enviar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(6, 6);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(84, 63);
            this.BtnEnviar.TabIndex = 2;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click_1);
            // 
            // txtEnviarSobrenome
            // 
            this.txtEnviarSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviarSobrenome.Location = new System.Drawing.Point(96, 41);
            this.txtEnviarSobrenome.Name = "txtEnviarSobrenome";
            this.txtEnviarSobrenome.Size = new System.Drawing.Size(230, 29);
            this.txtEnviarSobrenome.TabIndex = 1;
            // 
            // txtEnviarNome
            // 
            this.txtEnviarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviarNome.Location = new System.Drawing.Point(96, 6);
            this.txtEnviarNome.Name = "txtEnviarNome";
            this.txtEnviarNome.Size = new System.Drawing.Size(230, 29);
            this.txtEnviarNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReceber);
            this.tabPage2.Controls.Add(this.txtReceberSobrenome);
            this.tabPage2.Controls.Add(this.txtReceberNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receber";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(6, 6);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(84, 63);
            this.btnReceber.TabIndex = 5;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // txtReceberSobrenome
            // 
            this.txtReceberSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceberSobrenome.Location = new System.Drawing.Point(96, 41);
            this.txtReceberSobrenome.Name = "txtReceberSobrenome";
            this.txtReceberSobrenome.Size = new System.Drawing.Size(230, 29);
            this.txtReceberSobrenome.TabIndex = 4;
            // 
            // txtReceberNome
            // 
            this.txtReceberNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceberNome.Location = new System.Drawing.Point(96, 6);
            this.txtReceberNome.Name = "txtReceberNome";
            this.txtReceberNome.Size = new System.Drawing.Size(230, 29);
            this.txtReceberNome.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 214);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Recebimento";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox txtEnviarSobrenome;
        private System.Windows.Forms.TextBox txtEnviarNome;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.TextBox txtReceberSobrenome;
        private System.Windows.Forms.TextBox txtReceberNome;
    }
}

