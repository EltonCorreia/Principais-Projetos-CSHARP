namespace PrjConexao
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(259, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(13, 65);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(259, 20);
            this.txtFone.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(13, 95);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(96, 52);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(115, 95);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(196, 95);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 5;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(196, 124);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 7;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(115, 124);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 6;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
    }
}

