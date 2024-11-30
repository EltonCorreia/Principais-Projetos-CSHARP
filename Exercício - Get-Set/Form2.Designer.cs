namespace Exercício___Get_Set
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
            btnV2 = new Button();
            lblTitulo = new Label();
            txtValor2 = new TextBox();
            SuspendLayout();
            // 
            // btnV2
            // 
            btnV2.Location = new Point(16, 69);
            btnV2.Name = "btnV2";
            btnV2.Size = new Size(94, 29);
            btnV2.TabIndex = 5;
            btnV2.Text = "Avançar";
            btnV2.UseVisualStyleBackColor = true;
            btnV2.Click += btnV2_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(16, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 20);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Digite o segundo valor:";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(12, 36);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(261, 27);
            txtValor2.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(btnV2);
            Controls.Add(lblTitulo);
            Controls.Add(txtValor2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnV2;
        private Label lblTitulo;
        private TextBox txtValor2;
    }
}