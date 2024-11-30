namespace _29052024
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtSobrenomeReceber = new System.Windows.Forms.TextBox();
            this.txtNomeReceber = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(10, 102);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(83, 23);
            this.btnReceber.TabIndex = 9;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // txtSobrenomeReceber
            // 
            this.txtSobrenomeReceber.Location = new System.Drawing.Point(10, 76);
            this.txtSobrenomeReceber.Name = "txtSobrenomeReceber";
            this.txtSobrenomeReceber.Size = new System.Drawing.Size(194, 20);
            this.txtSobrenomeReceber.TabIndex = 8;
            // 
            // txtNomeReceber
            // 
            this.txtNomeReceber.Location = new System.Drawing.Point(10, 28);
            this.txtNomeReceber.Name = "txtNomeReceber";
            this.txtNomeReceber.Size = new System.Drawing.Size(194, 20);
            this.txtNomeReceber.TabIndex = 7;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(7, 60);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 6;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 137);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.txtSobrenomeReceber);
            this.Controls.Add(this.txtNomeReceber);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.TextBox txtSobrenomeReceber;
        private System.Windows.Forms.TextBox txtNomeReceber;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
    }
}