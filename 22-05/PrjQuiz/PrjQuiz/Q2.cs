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
    public partial class Q2 : Form
    {
        Ponte cp = new Ponte();

        public Q2()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            String x = "";
            if (rdrbtn2.Checked)
            {
                x = "s";
            }
            else
            {
                x = "n";
            }
            cp.setQ2(x);
            Q3 q3 = new Q3();
            q3.Show();

            //Resposta res = new Resposta();
            //res.Show();
        }
    }
}
