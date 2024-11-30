namespace _04062024
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
            btnEnviarReceber = new Button();
            lblMensagem = new Label();
            txtMensagemReceber = new TextBox();
            SuspendLayout();
            // 
            // btnEnviarReceber
            // 
            btnEnviarReceber.Location = new Point(12, 72);
            btnEnviarReceber.Name = "btnEnviarReceber";
            btnEnviarReceber.Size = new Size(94, 29);
            btnEnviarReceber.TabIndex = 5;
            btnEnviarReceber.Text = "Receber";
            btnEnviarReceber.UseVisualStyleBackColor = true;
            btnEnviarReceber.Click += btnEnviarReceber_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(12, 16);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(82, 20);
            lblMensagem.TabIndex = 4;
            lblMensagem.Text = "Mensagem";
            // 
            // txtMensagemReceber
            // 
            txtMensagemReceber.Location = new Point(12, 39);
            txtMensagemReceber.Name = "txtMensagemReceber";
            txtMensagemReceber.Size = new Size(278, 27);
            txtMensagemReceber.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 117);
            Controls.Add(btnEnviarReceber);
            Controls.Add(lblMensagem);
            Controls.Add(txtMensagemReceber);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarReceber;
        private Label lblMensagem;
        private TextBox txtMensagemReceber;
    }
}