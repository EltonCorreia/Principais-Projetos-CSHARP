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
    public partial class Q5 : Form
    {

        Ponte cp = new Ponte();

        public Q5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String x = "";
            if (rdrbtn3.Checked)
            {
                x = "s";
            }
            else
            {
                x = "n";
            }
            cp.setQ5(x);
            Q6 q6 = new Q6();
            q6.Show();

            //Resposta res = new Resposta();
            //res.Show();
        }
    }
}
