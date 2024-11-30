using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjArrayList
{
    public partial class Form1 : Form
    {

        List<int> lst = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst.Add(5);
            lst.Add(11);
            lst.Add(20);

            lblCadastrado.Text = "";
            for (int i = 0; i < lst.Count; i++)
                lblCadastrado.Text = lblCadastrado.Text + lst.ElementAt(i) + "|";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtCadastrado.Text);
            int pos = -1;
            for (int i = 0; i < lst.Count; i++)
            {
                if (num == lst.ElementAt(i))
                {
                    pos = i;
                }
            }

            MessageBox.Show(pos + "");

        }
    }
}
