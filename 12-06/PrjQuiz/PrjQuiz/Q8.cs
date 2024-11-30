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
    public partial class Q8 : Form
    {
        Ponte cp = new Ponte();

        public Q8()
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
            cp.setQ8(x);
            Q9 q9 = new Q9();
            q9.Show();

        }
    }
}
