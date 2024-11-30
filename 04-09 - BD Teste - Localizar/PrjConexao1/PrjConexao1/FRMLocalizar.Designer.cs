namespace PrjConexao1
{
    partial class FRMLocalizar
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
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(12, 12);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(246, 20);
            this.txtLocalizar.TabIndex = 0;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(264, 12);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(90, 23);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 148);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FRMLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 209);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtLocalizar);
            this.Name = "FRMLocalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}