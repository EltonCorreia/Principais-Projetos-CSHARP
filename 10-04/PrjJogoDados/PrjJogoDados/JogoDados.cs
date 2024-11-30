using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjJogoDados
{
    public partial class JogoDados : Form
    {
        Sortear sorteio = new Sortear();

        public JogoDados()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            int x = sorteio.sorteio();
            if (x == 0)
                pctDado.Image = Properties.Resources.dado1;
            if (x == 1)
                pctDado.Image = Properties.Resources.dado2;
            if (x == 2)
                pctDado.Image = Properties.Resources.dado3;
            if (x == 3)
                pctDado.Image = Properties.Resources.dado4;
            if (x == 4)
                pctDado.Image = Properties.Resources.dado5;
            if (x == 5)
                pctDado.Image = Properties.Resources.dado6;
        }

        private void rdoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = sorteio.sorteio();
            if (x == 0)
                pctDado.Image = Properties.Resources.dado1;
            if (x == 1)
                pctDado.Image = Properties.Resources.dado2;
            if (x == 2)
                pctDado.Image = Properties.Resources.dado3;
            if (x == 3)
                pctDado.Image = Properties.Resources.dado4;
            if (x == 4)
                pctDado.Image = Properties.Resources.dado5;
            if (x == 5)
                pctDado.Image = Properties.Resources.dado6;
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnDado2_Click(object sender, EventArgs e)
        {

            int y = sorteio.sorteio();
            if (y == 0)
                pctDado2.Image = Properties.Resources.dado1;
            if (y == 1)
                pctDado2.Image = Properties.Resources.dado2;
            if (y == 2)
                pctDado2.Image = Properties.Resources.dado3;
            if (y == 3)
                pctDado2.Image = Properties.Resources.dado4;
            if (y == 4)
                pctDado2.Image = Properties.Resources.dado5;
            if (y == 5)
                pctDado2.Image = Properties.Resources.dado6;

        }

    }
}
