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
    public partial class Q4 : Form
    {

        Ponte cp = new Ponte();

        public Q4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
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
            cp.setQ4(x);
            Q5 q5 = new Q5();
            q5.Show();

            //Resposta res = new Resposta();
            //res.Show();
        }
    }
}
