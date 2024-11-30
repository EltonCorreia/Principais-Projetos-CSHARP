namespace _01062024
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
            txtUser = new TextBox();
            lblUser = new Label();
            btnEnviar = new Button();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblHobby = new Label();
            txtHobby = new TextBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 43);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(271, 27);
            txtUser.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(59, 20);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuário";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 192);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(12, 73);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(47, 20);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(12, 96);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(271, 27);
            txtIdade.TabIndex = 3;
            // 
            // lblHobby
            // 
            lblHobby.AutoSize = true;
            lblHobby.Location = new Point(12, 126);
            lblHobby.Name = "lblHobby";
            lblHobby.Size = new Size(54, 20);
            lblHobby.TabIndex = 6;
            lblHobby.Text = "Hobby";
            // 
            // txtHobby
            // 
            txtHobby.Location = new Point(12, 149);
            txtHobby.Name = "txtHobby";
            txtHobby.Size = new Size(271, 27);
            txtHobby.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 233);
            Controls.Add(lblHobby);
            Controls.Add(txtHobby);
            Controls.Add(lblIdade);
            Controls.Add(txtIdade);
            Controls.Add(btnEnviar);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enviar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label lblUser;
        private Button btnEnviar;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblHobby;
        private TextBox txtHobby;
    }
}
