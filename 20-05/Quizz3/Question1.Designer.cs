namespace Quizz3
{
    partial class Question1
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
            lbl1 = new Label();
            rB1 = new RadioButton();
            rB2 = new RadioButton();
            rB3 = new RadioButton();
            rB4 = new RadioButton();
            btn1 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(64, 48);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(281, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Qual é o maior planeta do sistema solar?";
            // 
            // rB1
            // 
            rB1.AutoSize = true;
            rB1.Location = new Point(72, 112);
            rB1.Name = "rB1";
            rB1.Size = new Size(63, 24);
            rB1.TabIndex = 1;
            rB1.TabStop = true;
            rB1.Text = "Terra";
            rB1.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            rB2.AutoSize = true;
            rB2.Location = new Point(72, 142);
            rB2.Name = "rB2";
            rB2.Size = new Size(69, 24);
            rB2.TabIndex = 2;
            rB2.TabStop = true;
            rB2.Text = "Marte";
            rB2.UseVisualStyleBackColor = true;
            // 
            // rB3
            // 
            rB3.AutoSize = true;
            rB3.Location = new Point(72, 172);
            rB3.Name = "rB3";
            rB3.Size = new Size(74, 24);
            rB3.TabIndex = 3;
            rB3.TabStop = true;
            rB3.Text = "Jupiter";
            rB3.UseVisualStyleBackColor = true;
            rB3.CheckedChanged += rB3_CheckedChanged;
            // 
            // rB4
            // 
            rB4.AutoSize = true;
            rB4.Location = new Point(72, 202);
            rB4.Name = "rB4";
            rB4.Size = new Size(79, 24);
            rB4.TabIndex = 4;
            rB4.TabStop = true;
            rB4.Text = "Netuno";
            rB4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(72, 266);
            btn1.Name = "btn1";
            btn1.Size = new Size(115, 32);
            btn1.TabIndex = 5;
            btn1.Text = "Proximo";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Question1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(374, 367);
            Controls.Add(btn1);
            Controls.Add(rB4);
            Controls.Add(rB3);
            Controls.Add(rB2);
            Controls.Add(rB1);
            Controls.Add(lbl1);
            Name = "Question1";
            Text = "Pergunta1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private RadioButton rB1;
        private RadioButton rB2;
        private RadioButton rB3;
        private RadioButton rB4;
        private Button btn1;
    }
}
