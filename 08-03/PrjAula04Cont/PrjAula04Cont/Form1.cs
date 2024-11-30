using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAula04Cont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s, m, h, d;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LblTimer.Text = DateTime.Now.ToString("T");

            s++;
            if (s > 59)
            {
                s = 0;
                m++;
            }
            if (m > 59)
            {
                m = 0;
                h++;
            }
            if (h > 23)
            {
                h = 0;
                d++;
                if (d > 6)
                    d = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate () { }))
            LblTimer.Text = DateTime.Now.ToString("T");
        }
    }
}
