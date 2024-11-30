using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliação_C____Nome_Sobrenome
{
    public partial class Form3 : Form
    {

        Avançar x = new Avançar();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            txtNomeReceber.Text = x.getnome();
            txtSobrenomeReceber.Text = x.getsobrenome();

        }
    }
}
