namespace Exercício___Get_Set
{
    partial class Form3
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
            btnSomar = new Button();
            lblTitulo = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(16, 69);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(94, 29);
            btnSomar.TabIndex = 8;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(16, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(78, 20);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Resultado:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 36);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(261, 27);
            txtResult.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(btnSomar);
            Controls.Add(lblTitulo);
            Controls.Add(txtResult);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private Label lblTitulo;
        private TextBox txtResult;
    }
}