using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAula04
{
    public partial class FrmAula04 : Form
    {
        public FrmAula04()
        {
            InitializeComponent();
        }

        private void FrmAula04_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 99; i++)
            {
                Lstprimario.Items.Add(i);
            }

        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            int pos = Lstprimario.SelectedIndex;
            String x = Lstprimario.Items[Lstprimario.SelectedIndex].ToString();
            Lstsecundario.Items.Add(x);
            Lstprimario.Items.RemoveAt(pos);
        }

        private void BtnTransferirVolta_Click(object sender, EventArgs e)
        {

        }

        private void FrmAula04_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmAula04_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
               {
                e.Cancel = true;
               }
        }
    }
}
