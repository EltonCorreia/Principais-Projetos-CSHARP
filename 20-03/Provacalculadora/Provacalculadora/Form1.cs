using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provacalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double v1;
        Double v2;
        String op = "";

        public Double calcular(Double v1, Double v2, String op)
        {
            Double x = 0;

            if (op == "+")
                x = v1 + v2;

            if (op == "-")
                x = v1 - v2;

            if (op == "*")
                x = v1 * v2;

            if (op == "/")
                x = v1 / v2;

            return x;
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {

            v1 = Double.Parse(txtvalor1.Text);
            v2 = Double.Parse(txtvalor2.Text);

            Double x = calcular(v1, v2, "+");

            txtresultado.Text = x.ToString();

        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {

            v1 = Double.Parse(txtvalor1.Text);
            v2 = Double.Parse(txtvalor2.Text);

            Double x = calcular(v1, v2, "-");

            txtresultado.Text = x.ToString();

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {

            v1 = Double.Parse(txtvalor1.Text);
            v2 = Double.Parse(txtvalor2.Text);

            Double x = calcular(v1, v2, "*");

            txtresultado.Text = x.ToString();

        }

        private void btndividir_Click(object sender, EventArgs e)
        {

            v1 = Double.Parse(txtvalor1.Text);
            v2 = Double.Parse(txtvalor2.Text);

            Double x = calcular(v1, v2, "/");

            txtresultado.Text = x.ToString();

        }
    }
}
