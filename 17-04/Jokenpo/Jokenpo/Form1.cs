using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class Form1 : Form
    {

        Sorteio sorteio = new Sorteio();

        int pontosJog1=0;
        int pontosJog2=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int x = rd.Next(3);
            int y = rd.Next(3);

            if (x == 0)
                pctVisor1.Image = Properties.Resources.papel;
            if (x == 1)
                pctVisor1.Image = Properties.Resources.pedra;
            if (x == 2)
                pctVisor1.Image = Properties.Resources.tesoura;

            if (y == 0)
                pctVisor2.Image = Properties.Resources.papel;
            if (y == 1)
                pctVisor2.Image = Properties.Resources.pedra;
            if (y == 2)
                pctVisor2.Image = Properties.Resources.tesoura;

            if(x == y)
            {
                pontosJog1++;
                pontosJog2++;
            }
            if (x > y)
            {
                pontosJog1++;
            }
            if (x < y)
            {
                pontosJog2++;
            }

            lblJog1.Text = pontosJog1 + "";
            lblJog2.Text = pontosJog2 + "";

        }

    }
}
