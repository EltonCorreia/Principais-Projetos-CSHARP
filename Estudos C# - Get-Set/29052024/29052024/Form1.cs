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
    public partial class Form1 : Form
    {

        Receber x = new Receber();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            x.setNome(txtNome.Text);

            x.setSobrenome(txtSobrenome.Text);

            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
