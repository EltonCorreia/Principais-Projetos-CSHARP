namespace Avaliação_C____Nome_Sobrenome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            btnAvançar = new Button();
            lblNome = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 27);
            txtNome.TabIndex = 0;
            // 
            // btnAvançar
            // 
            btnAvançar.Location = new Point(12, 65);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(94, 29);
            btnAvançar.TabIndex = 1;
            btnAvançar.Text = "Avançar";
            btnAvançar.UseVisualStyleBackColor = true;
            btnAvançar.Click += btnAvançar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 109);
            Controls.Add(lblNome);
            Controls.Add(btnAvançar);
            Controls.Add(txtNome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnAvançar;
        private Label lblNome;
    }
}
