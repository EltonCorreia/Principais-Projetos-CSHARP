using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz3
{
    public partial class Question2 : Form
    {
        Ponte cp = new Ponte();
        public Question2()
        {
            InitializeComponent();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cp.setNome("Pgt1");

            Final frn3 = new Final();
            frn3.ShowDialog();
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            cp.setContar(1);
        }
    }
}
