using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01062024
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

            txtUseReceber.Text = x.getNome();

            txtIdadeReceber.Text = x.getIdade();

            txtHobbyReceber.Text = x.gethobby();

            MessageBox.Show("Olá! Seu nome é " + txtUseReceber.Text + "; Sua idade é " + txtIdadeReceber.Text + " e seu hobby é " + txtHobbyReceber.Text + ".");

        }

    }
}
