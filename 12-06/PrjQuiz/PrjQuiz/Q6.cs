﻿using System;
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
    public partial class Q6 : Form
    {

        Ponte cp = new Ponte();

        public Q6()
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
            cp.setQ6(x);
            Q7 q7 = new Q7();
            q7.Show();

            //Resposta res = new Resposta();
            //res.Show();
        }
    }
}
