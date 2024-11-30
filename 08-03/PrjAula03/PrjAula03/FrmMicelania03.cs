using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAula03
{
    public partial class FrmMicelania03 : Form
    {
        int contar = 0; //área pública
        int direcao = 0; //0--> positivo, 1--> negativo

        public FrmMicelania03()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = contar;
            lstTexto.Items.Add(contar);
            if (direcao == 0)
                contar++;
            else
                contar--;
            if(contar >= 100)
                direcao = 1;
            if(contar <= 0)
                direcao = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
}
