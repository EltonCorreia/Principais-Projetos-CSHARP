using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjArraySimples1
{
    public partial class Form1 : Form
    {
        const int MAX = 3;
        int[] x = new int[MAX];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x[0] = 99;
            x[1] = 73;
            x[2] = 27;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            int num = int.Parse(txtNum.Text);
            int pos = -1;

            for (int i = 0; i<MAX; i++)
            {
                if (num == x[i])
                    pos = i;
                
                    MessageBox.Show(pos + "");
                
            }
        }
    }
}
