namespace CalculadoraCientifica
{
    partial class FrmCalculadora
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.rdoBinario = new System.Windows.Forms.RadioButton();
            this.rdoDecimal = new System.Windows.Forms.RadioButton();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.LightCyan;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(221, 49);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(72, 308);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 40);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(127, 308);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(51, 40);
            this.btnVirgula.TabIndex = 3;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(182, 308);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(51, 40);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(182, 262);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(51, 40);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(127, 262);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 40);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 40);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 262);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 40);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(182, 216);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(51, 40);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(127, 216);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 40);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(72, 216);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 40);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(17, 216);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 40);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // rdoBinario
            // 
            this.rdoBinario.AutoSize = true;
            this.rdoBinario.Location = new System.Drawing.Point(14, 88);
            this.rdoBinario.Name = "rdoBinario";
            this.rdoBinario.Size = new System.Drawing.Size(57, 17);
            this.rdoBinario.TabIndex = 13;
            this.rdoBinario.Text = "Binário";
            this.rdoBinario.UseVisualStyleBackColor = true;
            this.rdoBinario.Click += new System.EventHandler(this.rdoBinario_Click);
            // 
            // rdoDecimal
            // 
            this.rdoDecimal.AutoSize = true;
            this.rdoDecimal.Checked = true;
            this.rdoDecimal.Location = new System.Drawing.Point(77, 88);
            this.rdoDecimal.Name = "rdoDecimal";
            this.rdoDecimal.Size = new System.Drawing.Size(63, 17);
            this.rdoDecimal.TabIndex = 14;
            this.rdoDecimal.TabStop = true;
            this.rdoDecimal.Text = "Decimal";
            this.rdoDecimal.UseVisualStyleBackColor = true;
            this.rdoDecimal.Click += new System.EventHandler(this.rdoDecimal_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(182, 124);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(51, 40);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(127, 124);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(51, 40);
            this.btnInverte.TabIndex = 17;
            this.btnInverte.Text = "+ / -";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(72, 124);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(51, 40);
            this.btnCos.TabIndex = 16;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(17, 124);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(51, 40);
            this.btnSeno.TabIndex = 15;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMult.Location = new System.Drawing.Point(182, 170);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(51, 40);
            this.btnMult.TabIndex = 22;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(127, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 40);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(72, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 40);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(17, 170);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 40);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(146, 78);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(247, 363);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.rdoDecimal);
            this.Controls.Add(this.rdoBinario);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplay);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.RadioButton rdoBinario;
        private System.Windows.Forms.RadioButton rdoDecimal;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBack;
    }
}

