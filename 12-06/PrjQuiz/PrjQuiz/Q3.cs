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
    public partial class Q3 : Form
    {

        Ponte cp = new Ponte();

        public Q3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
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
            cp.setQ3(x);
            Q4 q4 = new Q4();
            q4.Show();

            //Resposta res = new Resposta();
            //res.Show();
        }
    }
}
