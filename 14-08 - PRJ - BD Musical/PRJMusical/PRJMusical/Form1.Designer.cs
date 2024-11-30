namespace PRJMusical
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(389, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID - Álbum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 77);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(389, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(12, 120);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(389, 20);
            this.txtLocalizacao.TabIndex = 4;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(13, 150);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(143, 63);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(162, 149);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 30);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(282, 149);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(120, 30);
            this.btnAvancar.TabIndex = 9;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(282, 183);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(120, 30);
            this.btnUltimo.TabIndex = 11;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(162, 183);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(120, 30);
            this.btnPrimeiro.TabIndex = 10;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 219);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(143, 31);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(281, 219);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 30);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(161, 219);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(120, 30);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 266);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD - Musical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
    }
}

