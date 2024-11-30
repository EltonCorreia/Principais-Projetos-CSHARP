using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJLogin
{
    public partial class FRMmenu : Form
    {
        public FRMmenu()
        {
            InitializeComponent();
        }

        private void MNUPF_Click(object sender, EventArgs e)
        {
            FRMPF pf = new FRMPF();
            pf.ShowDialog();
        }

        private void MNUPJ_Click(object sender, EventArgs e)
        {
            FRMPJ pj = new FRMPJ();
            pj.ShowDialog();
        }

        private void MNULogOff_Click(object sender, EventArgs e)
        {
            FRMLogin login = new FRMLogin();
            login.Show();
        }

        private void MNUSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
