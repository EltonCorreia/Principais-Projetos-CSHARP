namespace _01062024
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
            btnReceber = new Button();
            lblUser = new Label();
            txtUseReceber = new TextBox();
            lblHobby = new Label();
            txtHobbyReceber = new TextBox();
            lblIdade = new Label();
            txtIdadeReceber = new TextBox();
            SuspendLayout();
            // 
            // btnReceber
            // 
            btnReceber.Location = new Point(12, 192);
            btnReceber.Name = "btnReceber";
            btnReceber.Size = new Size(94, 29);
            btnReceber.TabIndex = 5;
            btnReceber.Text = "Receber";
            btnReceber.UseVisualStyleBackColor = true;
            btnReceber.Click += btnReceber_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(13, 11);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(59, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuário";
            // 
            // txtUseReceber
            // 
            txtUseReceber.Location = new Point(13, 34);
            txtUseReceber.Name = "txtUseReceber";
            txtUseReceber.Size = new Size(271, 27);
            txtUseReceber.TabIndex = 3;
            // 
            // lblHobby
            // 
            lblHobby.AutoSize = true;
            lblHobby.Location = new Point(13, 118);
            lblHobby.Name = "lblHobby";
            lblHobby.Size = new Size(54, 20);
            lblHobby.TabIndex = 10;
            lblHobby.Text = "Hobby";
            // 
            // txtHobbyReceber
            // 
            txtHobbyReceber.Location = new Point(13, 141);
            txtHobbyReceber.Name = "txtHobbyReceber";
            txtHobbyReceber.Size = new Size(271, 27);
            txtHobbyReceber.TabIndex = 9;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(13, 65);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(47, 20);
            lblIdade.TabIndex = 8;
            lblIdade.Text = "Idade";
            // 
            // txtIdadeReceber
            // 
            txtIdadeReceber.Location = new Point(13, 88);
            txtIdadeReceber.Name = "txtIdadeReceber";
            txtIdadeReceber.Size = new Size(271, 27);
            txtIdadeReceber.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 233);
            Controls.Add(lblHobby);
            Controls.Add(txtHobbyReceber);
            Controls.Add(lblIdade);
            Controls.Add(txtIdadeReceber);
            Controls.Add(btnReceber);
            Controls.Add(lblUser);
            Controls.Add(txtUseReceber);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReceber;
        private Label lblUser;
        private TextBox txtUseReceber;
        private Label lblHobby;
        private TextBox txtHobbyReceber;
        private Label lblIdade;
        private TextBox txtIdadeReceber;
    }
}