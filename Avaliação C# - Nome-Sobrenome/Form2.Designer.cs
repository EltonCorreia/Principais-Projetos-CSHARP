namespace Avaliação_C____Nome_Sobrenome
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
            lblSobrenome = new Label();
            btnAvançar = new Button();
            txtSobrenome = new TextBox();
            SuspendLayout();
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(12, 12);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(86, 20);
            lblSobrenome.TabIndex = 5;
            lblSobrenome.Text = "Sobrenome";
            // 
            // btnAvançar
            // 
            btnAvançar.Location = new Point(12, 68);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(94, 29);
            btnAvançar.TabIndex = 4;
            btnAvançar.Text = "Avançar";
            btnAvançar.UseVisualStyleBackColor = true;
            btnAvançar.Click += btnAvançar_Click;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(12, 35);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(275, 27);
            txtSobrenome.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 109);
            Controls.Add(lblSobrenome);
            Controls.Add(btnAvançar);
            Controls.Add(txtSobrenome);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobrenome;
        private Button btnAvançar;
        private TextBox txtSobrenome;
    }
}