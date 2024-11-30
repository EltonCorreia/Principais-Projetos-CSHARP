namespace Quizz3
{
    partial class Question2
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
            lbl2 = new Label();
            rB5 = new RadioButton();
            rB6 = new RadioButton();
            rB7 = new RadioButton();
            rB8 = new RadioButton();
            btn2 = new Button();
            SuspendLayout();
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(65, 71);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(188, 20);
            lbl2.TabIndex = 0;
            lbl2.Text = "Qual é a capital da França?";
            // 
            // rB5
            // 
            rB5.AutoSize = true;
            rB5.Location = new Point(71, 125);
            rB5.Name = "rB5";
            rB5.Size = new Size(73, 24);
            rB5.TabIndex = 1;
            rB5.TabStop = true;
            rB5.Text = "Lisboa";
            rB5.UseVisualStyleBackColor = true;
            // 
            // rB6
            // 
            rB6.AutoSize = true;
            rB6.Location = new Point(71, 155);
            rB6.Name = "rB6";
            rB6.Size = new Size(69, 24);
            rB6.TabIndex = 2;
            rB6.TabStop = true;
            rB6.Text = "Madri";
            rB6.UseVisualStyleBackColor = true;
            // 
            // rB7
            // 
            rB7.AutoSize = true;
            rB7.Location = new Point(71, 185);
            rB7.Name = "rB7";
            rB7.Size = new Size(65, 24);
            rB7.TabIndex = 3;
            rB7.TabStop = true;
            rB7.Text = "Luvre";
            rB7.UseVisualStyleBackColor = true;
            // 
            // rB8
            // 
            rB8.AutoSize = true;
            rB8.Location = new Point(71, 215);
            rB8.Name = "rB8";
            rB8.Size = new Size(60, 24);
            rB8.TabIndex = 4;
            rB8.TabStop = true;
            rB8.Text = "Paris";
            rB8.UseVisualStyleBackColor = true;
            rB8.CheckedChanged += rB8_CheckedChanged;
            // 
            // btn2
            // 
            btn2.Location = new Point(114, 288);
            btn2.Name = "btn2";
            btn2.Size = new Size(131, 53);
            btn2.TabIndex = 5;
            btn2.Text = "Proximo";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Question2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(btn2);
            Controls.Add(rB8);
            Controls.Add(rB7);
            Controls.Add(rB6);
            Controls.Add(rB5);
            Controls.Add(lbl2);
            Name = "Question2";
            Text = "Pergunta 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl2;
        private RadioButton rB5;
        private RadioButton rB6;
        private RadioButton rB7;
        private RadioButton rB8;
        private Button btn2;
    }
}