using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTradutor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            String[] palavraportugues = new String[] { "cachorro" };

            String[] palavraingles = new String[] { "dog"};

            String dig = txtPortugues.Text;

            dig = dig.ToLower();

            int pos = 0;

            for (int i = 0; i < palavraportugues.Length; i++)
            {

                if (dig.Equals(palavraportugues[i]))
                {
                    pos = i;
                    break;
                }

                txtIngles.Text = palavraingles[pos];

            }
        }
    }
}
