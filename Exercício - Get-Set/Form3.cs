using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício___Get_Set
{
    public partial class Form3 : Form
    {

        Avançar x = new Avançar();

        int v1, v2, soma;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            v1 = x.getf1();
            v2 = x.getf2();

            int soma = (v1 + v2);

            txtResult.Text = soma.ToString();

        }
    }
}
