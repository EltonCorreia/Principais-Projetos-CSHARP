using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Boa noite");
            //if (btn2.Visible == true)
            //{
            //btn2.Visible = false;
            //}
            //else
            //btn2.Visible = true;

            //btn2.Enabled = !btn2.Enabled;

            //txtTexto.Text = "Boa noite!";
            //lblTexto.Text = "Boa noite!";

            //txtTexto.Text = "Boa noite!";

            //txtTexto2.Text = txtTexto.Text;
            //txtTexto.Text = "";

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            chkCaixa1.Checked = !chkCaixa1.Checked;

            //MessageBox.Show("Boa noite");

            //txtTexto.Text = txtTexto2.Text;
            //txtTexto2.Text = "";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (chkCaixa3.Checked || chkCaixa2.Checked && chkCaixa1.Checked)

            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
