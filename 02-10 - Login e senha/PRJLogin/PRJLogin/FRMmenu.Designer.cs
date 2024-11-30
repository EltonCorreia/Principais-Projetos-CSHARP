namespace PRJLogin
{
    partial class FRMmenu
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
            this.MNU = new System.Windows.Forms.MenuStrip();
            this.oPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUPF = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUPJ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MNUSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MNULogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.MNU.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNU
            // 
            this.MNU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MNU.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPToolStripMenuItem,
            this.MNULogOff});
            this.MNU.Location = new System.Drawing.Point(0, 0);
            this.MNU.Name = "MNU";
            this.MNU.Size = new System.Drawing.Size(607, 25);
            this.MNU.TabIndex = 1;
            this.MNU.Text = "menuStrip1";
            // 
            // oPToolStripMenuItem
            // 
            this.oPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUPF,
            this.MNUPJ,
            this.toolStripMenuItem1,
            this.MNUSair});
            this.oPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.oPToolStripMenuItem.Name = "oPToolStripMenuItem";
            this.oPToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.oPToolStripMenuItem.Text = "OP";
            // 
            // MNUPF
            // 
            this.MNUPF.Name = "MNUPF";
            this.MNUPF.Size = new System.Drawing.Size(272, 22);
            this.MNUPF.Text = "Abrir Formulário (Pessoa Física)";
            this.MNUPF.Click += new System.EventHandler(this.MNUPF_Click);
            // 
            // MNUPJ
            // 
            this.MNUPJ.Name = "MNUPJ";
            this.MNUPJ.Size = new System.Drawing.Size(272, 22);
            this.MNUPJ.Text = "Abrir Formulário (Pessoa Jurídica)";
            this.MNUPJ.Click += new System.EventHandler(this.MNUPJ_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(269, 6);
            // 
            // MNUSair
            // 
            this.MNUSair.Name = "MNUSair";
            this.MNUSair.Size = new System.Drawing.Size(272, 22);
            this.MNUSair.Text = "Sair";
            this.MNUSair.Click += new System.EventHandler(this.MNUSair_Click);
            // 
            // MNULogOff
            // 
            this.MNULogOff.ForeColor = System.Drawing.Color.White;
            this.MNULogOff.Name = "MNULogOff";
            this.MNULogOff.Size = new System.Drawing.Size(61, 21);
            this.MNULogOff.Text = "LogOff";
            this.MNULogOff.Click += new System.EventHandler(this.MNULogOff_Click);
            // 
            // FRMmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 385);
            this.Controls.Add(this.MNU);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MNU;
            this.Name = "FRMmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MNU.ResumeLayout(false);
            this.MNU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MNU;
        private System.Windows.Forms.ToolStripMenuItem oPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNUPF;
        private System.Windows.Forms.ToolStripMenuItem MNUPJ;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MNUSair;
        private System.Windows.Forms.ToolStripMenuItem MNULogOff;
    }
}

