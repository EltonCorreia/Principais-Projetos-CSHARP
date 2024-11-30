namespace Quizz3
{
    partial class Final
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
            lblacerto = new Label();
            lblResultado = new Label();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // lblacerto
            // 
            lblacerto.AutoSize = true;
            lblacerto.Location = new Point(56, 53);
            lblacerto.Name = "lblacerto";
            lblacerto.Size = new Size(160, 20);
            lblacerto.TabIndex = 0;
            lblacerto.Text = "Parabéns você acertou:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(58, 91);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 1;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(80, 208);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(136, 42);
            btnResultado.TabIndex = 4;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 440);
            Controls.Add(btnResultado);
            Controls.Add(lblResultado);
            Controls.Add(lblacerto);
            Name = "Final";
            Text = "Resultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblacerto;
        private Label lblResultado;
        private Button btnResultado;
    }
}