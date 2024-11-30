namespace _04062024_pt2
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
            lblP1 = new Label();
            rdrP1Sim = new RadioButton();
            rdrP1Não = new RadioButton();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // lblP1
            // 
            lblP1.AutoSize = true;
            lblP1.Location = new Point(12, 9);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(210, 20);
            lblP1.TabIndex = 0;
            lblP1.Text = "Deseja ir pra segunda página?";
            // 
            // rdrP1Sim
            // 
            rdrP1Sim.AutoSize = true;
            rdrP1Sim.Location = new Point(12, 42);
            rdrP1Sim.Name = "rdrP1Sim";
            rdrP1Sim.Size = new Size(55, 24);
            rdrP1Sim.TabIndex = 1;
            rdrP1Sim.TabStop = true;
            rdrP1Sim.Text = "Sim";
            rdrP1Sim.UseVisualStyleBackColor = true;
            // 
            // rdrP1Não
            // 
            rdrP1Não.AutoSize = true;
            rdrP1Não.Location = new Point(12, 72);
            rdrP1Não.Name = "rdrP1Não";
            rdrP1Não.Size = new Size(58, 24);
            rdrP1Não.TabIndex = 2;
            rdrP1Não.TabStop = true;
            rdrP1Não.Text = "Não";
            rdrP1Não.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(99, 42);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(123, 54);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 112);
            Controls.Add(btnVerificar);
            Controls.Add(rdrP1Não);
            Controls.Add(rdrP1Sim);
            Controls.Add(lblP1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblP1;
        private RadioButton rdrP1Sim;
        private RadioButton rdrP1Não;
        private Button btnVerificar;
    }
}
