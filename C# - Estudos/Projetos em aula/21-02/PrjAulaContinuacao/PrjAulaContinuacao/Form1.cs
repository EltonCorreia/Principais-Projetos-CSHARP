using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAulaContinuacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarlist_Click(object sender, EventArgs e)
        {
            try
            {

                cmbTexto.Items.Clear();
                lstTexto.Items.Clear();
                int n = int.Parse(txtNumero.Text);
                for (int i = 0; i < 11; i++)
                {

                    lstTexto.Items.Add(n + " x " + i + " = " + i);
                    cmbTexto.Items.Add(n + " x " + i + " = " + i);
                }
            }
            catch (Exception erro) { }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lstTexto.Items.Add("ETESP");
        }
    }
}
