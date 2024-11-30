using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29052024
{
    public partial class Form2 : Form
    {

        Receber x = new Receber();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            txtNomeReceber.Text = x.getNome();

            txtSobrenomeReceber.Text = x.getSobrenome();

            //MessageBox.Show("Seu nome é"  + x.getNome() + "Seu sobrenome é"  + x.getSobrenome());
        }
    }
}
