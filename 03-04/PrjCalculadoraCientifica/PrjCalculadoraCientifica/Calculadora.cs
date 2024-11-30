using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCalculadoraCientifica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        string operador = "";
        double valor2 = 0.0;

        private void mostrarBotoesBinario(bool x)
        {
            btnZero.Enabled = x;
            btnUm.Enabled = x;
            btnDois.Enabled = !x;
            btnTres.Enabled = !x;
            btnQuatro.Enabled = !x;
            btnCinco.Enabled = !x;
            btnSeis.Enabled = !x;
            btnSete.Enabled = !x;
            btnOito.Enabled = !x;
            btnNove.Enabled = !x;
            if (x == false)
            {
                btnZero.Enabled = true;
                btnUm.Enabled = true;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            { 
            lblDisplay.Text = "";
            }
            lblDisplay.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "7";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "9";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text += "8";
        }

        //Operações:

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor2 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            valor2 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor2 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor2 = double.Parse (lblDisplay.Text);
            lblDisplay.Text = "";   
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            operador = "sen";
            valor2 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                lblDisplay.Text = (valor2 + (double.Parse(lblDisplay.Text))) + "";
            }
            if (operador == "-")
            {
                lblDisplay.Text = (valor2 - (double.Parse(lblDisplay.Text))) + "";
            }
            if (operador == "*")
            {
                lblDisplay.Text = (valor2 * (double.Parse(lblDisplay.Text))) + "";
            }
            if (operador == "/")
            {
                lblDisplay.Text = (valor2 / (double.Parse(lblDisplay.Text))) + "";
            }
            if (operador == "sen")
            {
                lblDisplay.Text = (Math.Sin(valor2 * (Math.PI / 180))) + "";
            }
            if (operador == "cos")
            {
                lblDisplay.Text = (Math.Cos(valor2 * (Math.PI / 180))) + "";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            operador = "cos";
            valor2 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            operador = "";
            valor2 = (0);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!lblDisplay.Text.Contains(","))
            {
                lblDisplay.Text += ",";
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if(!lblDisplay.Text.Contains('-'))
            {
                lblDisplay.Text = "-" + lblDisplay.Text;
            }
            else
            {
                lblDisplay.Text = lblDisplay.Text.Trim('-');
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            mostrarBotoesBinario(true);

            int n, r;
            String b = "";
            n = int.Parse(lblDisplay.Text);
            while (n > 0)
            {
                r = n % 2;
                n = n / 2;
                if (r == 0)
                    b = "0" + b;
                else
                    b = "1" + b;
            }
            lblDisplay.Text = b;

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

            mostrarBotoesBinario(false);

            int i, tamanho, n = 0;
            String texto = lblDisplay.Text;
            tamanho = texto.Length;
            for (i = 0; i <= (texto.Length) - 1; i++)
            {
                tamanho--;
                if (texto[i] == '1')
                    n = n + (int)Math.Pow(2, tamanho);
            }
            lblDisplay.Text = (n).ToString();

        }

        private void btnSeta_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 0)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
        }
    }


}
