namespace _04062024_pt2
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
            rdrP2Não = new RadioButton();
            rdrP2Sim = new RadioButton();
            lblP2 = new Label();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // rdrP2Não
            // 
            rdrP2Não.AutoSize = true;
            rdrP2Não.Location = new Point(15, 76);
            rdrP2Não.Name = "rdrP2Não";
            rdrP2Não.Size = new Size(58, 24);
            rdrP2Não.TabIndex = 5;
            rdrP2Não.TabStop = true;
            rdrP2Não.Text = "Não";
            rdrP2Não.UseVisualStyleBackColor = true;
            // 
            // rdrP2Sim
            // 
            rdrP2Sim.AutoSize = true;
            rdrP2Sim.Location = new Point(15, 46);
            rdrP2Sim.Name = "rdrP2Sim";
            rdrP2Sim.Size = new Size(55, 24);
            rdrP2Sim.TabIndex = 4;
            rdrP2Sim.TabStop = true;
            rdrP2Sim.Text = "Sim";
            rdrP2Sim.UseVisualStyleBackColor = true;
            // 
            // lblP2
            // 
            lblP2.AutoSize = true;
            lblP2.Location = new Point(15, 13);
            lblP2.Name = "lblP2";
            lblP2.Size = new Size(196, 20);
            lblP2.TabIndex = 3;
            lblP2.Text = "Deseja ir pra última página?";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(97, 46);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(123, 54);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 112);
            Controls.Add(btnVerificar);
            Controls.Add(rdrP2Não);
            Controls.Add(rdrP2Sim);
            Controls.Add(lblP2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdrP2Não;
        private RadioButton rdrP2Sim;
        private Label lblP2;
        private Button btnVerificar;
    }
}