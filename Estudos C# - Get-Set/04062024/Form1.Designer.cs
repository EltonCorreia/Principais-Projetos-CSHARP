namespace _04062024
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
            txtMensagem = new TextBox();
            lblMensagem = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(12, 37);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(278, 27);
            txtMensagem.TabIndex = 0;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(12, 14);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(82, 20);
            lblMensagem.TabIndex = 1;
            lblMensagem.Text = "Mensagem";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 70);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 117);
            Controls.Add(btnEnviar);
            Controls.Add(lblMensagem);
            Controls.Add(txtMensagem);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMensagem;
        private Label lblMensagem;
        private Button btnEnviar;
    }
}
