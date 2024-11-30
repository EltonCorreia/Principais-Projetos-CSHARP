using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double calcular(Double v1, Double v2, String op)
        {

            double x = 0;

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

        private void btnSomar_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //txtTotal.Text = calcular(v1, v2,"+").ToString();

            //Double t = v1 + v2;

            //txtTotal.Text = t.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //txtTotal.Text = calcular(v1, v2, "-").ToString();

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //txtTotal.Text = calcular(v1, v2).ToString();

            //Double t2 = v1 - v2;

            //txtTotal.Text = t2.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //txtTotal.Text = calcular(v1, v2, "*").ToString();

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //Double t3 = v1 * v2;

            //txtTotal.Text = t3.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //txtTotal.Text = calcular(v1, v2, "/").ToString();

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //Double t4 = v1 / v2;

            //txtTotal.Text = t4.ToString();

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);

            //Double t5 = Math.Sin(v1*(Math.PI/180));

            //txtTotal.Text = t5.ToString();

        }

        private void btnTangente_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //Double t6 = Math.Tan(v1 * (Math.PI / 180));

            //txtTotal.Text = t6.ToString();

        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {

            //Double v1 = Double.Parse(txtValor1.Text);
            //Double v2 = Double.Parse(txtValor2.Text);

            //Double t7 = Math.Cos(v1 * (Math.PI / 180));

            //txtTotal.Text = t7.ToString();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Double v1 = Double.Parse(txtValor1.Text);
            Double v2 = Double.Parse(txtValor2.Text);
            String sinal = "";

            if (rdoSomar.Checked)

                sinal = "+";

            if (rdoSubtrair.Checked)

                sinal = "-";

            if (rdoMultiplicar.Checked)

                sinal = "*";

            if (rdoDivisao.Checked)

                sinal = "/";

            txtTotal.Text = calcular(v1, v2, sinal).ToString();

        }

    }
}
