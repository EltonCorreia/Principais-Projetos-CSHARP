using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjQuiz
{
    public partial class Q1 : Form
    {
        Ponte cp = new Ponte();

        public Q1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            String x = "";
            if (rdrbtn4.Checked)
            {
                x = "s";
            }
            else
            {
                x = "n";
            }
            cp.setQ1(x);
            Q2 q2 = new Q2();
            q2.Show();

        }
    }
}
