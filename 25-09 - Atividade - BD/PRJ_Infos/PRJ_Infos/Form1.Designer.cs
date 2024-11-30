namespace PRJ_Infos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.cbAtivoPassivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda de Contatos";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(18, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(329, 34);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 195);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 34);
            this.txtNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fone";
            // 
            // txtFone
            // 
            this.txtFone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFone.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(18, 266);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(644, 34);
            this.txtFone.TabIndex = 5;
            // 
            // cbAtivoPassivo
            // 
            this.cbAtivoPassivo.AutoSize = true;
            this.cbAtivoPassivo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivoPassivo.Location = new System.Drawing.Point(18, 317);
            this.cbAtivoPassivo.Name = "cbAtivoPassivo";
            this.cbAtivoPassivo.Size = new System.Drawing.Size(107, 21);
            this.cbAtivoPassivo.TabIndex = 7;
            this.cbAtivoPassivo.Text = "Cliente Ativo?";
            this.cbAtivoPassivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data";
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.ForeColor = System.Drawing.Color.White;
            this.btnPrimeiro.Location = new System.Drawing.Point(22, 256);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(114, 38);
            this.btnPrimeiro.TabIndex = 16;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnAvancar);
            this.panel3.Controls.Add(this.btnVoltar);
            this.panel3.Controls.Add(this.btnUltimo);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnAlterar);
            this.panel3.Controls.Add(this.btnPrimeiro);
            this.panel3.Controls.Add(this.btnIncluir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(681, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 369);
            this.panel3.TabIndex = 20;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.White;
            this.btnAvancar.Location = new System.Drawing.Point(136, 300);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(114, 38);
            this.btnAvancar.TabIndex = 21;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(22, 300);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 38);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.White;
            this.btnUltimo.Location = new System.Drawing.Point(136, 256);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(114, 38);
            this.btnUltimo.TabIndex = 19;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(22, 171);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(228, 68);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(22, 98);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(228, 68);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(22, 24);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(228, 68);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(353, 113);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(309, 34);
            this.txtData.TabIndex = 21;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(353, 195);
            this.txtValor.Mask = "$999,99";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(309, 34);
            this.txtValor.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 369);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAtivoPassivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.CheckBox cbAtivoPassivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtValor;
    }
}

