namespace Avaliação_C____Nome_Sobrenome
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
            lblUsuario = new Label();
            btnMostrar = new Button();
            txtNomeReceber = new TextBox();
            txtSobrenomeReceber = new TextBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 12);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuário";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 104);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNomeReceber
            // 
            txtNomeReceber.Location = new Point(12, 35);
            txtNomeReceber.Name = "txtNomeReceber";
            txtNomeReceber.Size = new Size(275, 27);
            txtNomeReceber.TabIndex = 6;
            // 
            // txtSobrenomeReceber
            // 
            txtSobrenomeReceber.Location = new Point(12, 71);
            txtSobrenomeReceber.Name = "txtSobrenomeReceber";
            txtSobrenomeReceber.Size = new Size(275, 27);
            txtSobrenomeReceber.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 149);
            Controls.Add(txtSobrenomeReceber);
            Controls.Add(lblUsuario);
            Controls.Add(btnMostrar);
            Controls.Add(txtNomeReceber);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnMostrar;
        private TextBox txtNomeReceber;
        private TextBox txtSobrenomeReceber;
    }
}