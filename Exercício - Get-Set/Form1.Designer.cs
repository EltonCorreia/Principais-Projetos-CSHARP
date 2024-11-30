namespace Exercício___Get_Set
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
            txtValor1 = new TextBox();
            lblTitulo = new Label();
            btnV1 = new Button();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(11, 32);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(261, 27);
            txtValor1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Digite o primeiro valor:";
            // 
            // btnV1
            // 
            btnV1.Location = new Point(15, 65);
            btnV1.Name = "btnV1";
            btnV1.Size = new Size(94, 29);
            btnV1.TabIndex = 2;
            btnV1.Text = "Avançar";
            btnV1.UseVisualStyleBackColor = true;
            btnV1.Click += btnV1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(btnV1);
            Controls.Add(lblTitulo);
            Controls.Add(txtValor1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private Label lblTitulo;
        private Button btnV1;
    }
}
