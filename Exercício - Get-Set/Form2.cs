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
    public partial class Form2 : Form
    {

        Avançar x = new Avançar();

        int v1, v2, soma;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            int v2 = int.Parse(txtValor2.Text);
            x.setf2(v2);

            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
