using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjForca
{
    public partial class Form1 : Form
    {

        String y = "sol";

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSorte_Click(object sender, EventArgs e)
        {

            String x = txtResponda.Text;

            for(int i=0;i<x.Length;i++)
            {
                String tentativa1 = x.ElementAt(i) + "";
                String tentativa2 = y.ElementAt(i) + "";

                if(tentativa1 != tentativa2)
                {
                    if(i == 0)
                    {
                        pctVisor.Image = Properties.Resources.cabeça;
                    }
                    if(i == 1)
                    {
                        pctVisor.Image = Properties.Resources.corpo_e_membros;
                    }
                    if (i == 2)
                    {
                        pctVisor.Image = Properties.Resources.corpo;
                    }
                    
                }

                if (tentativa1 == tentativa2)
                {
                    pctVisor.Image = Properties.Resources.ganhou;
                }

            }
        }
    }
}
