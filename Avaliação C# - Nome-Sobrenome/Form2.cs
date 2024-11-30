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
    public partial class Form2 : Form
    {

        Avançar x = new Avançar();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            x.setsobrenome(txtSobrenome.Text);

            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
