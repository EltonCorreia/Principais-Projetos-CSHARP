using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class FrmCalculadora : Form
    {

        String operador = "";
        double valor1 = 0.0;
        Calcula calc = new Calcula();


        private void mostrarBotoesBinario(bool x)
        {
            btn0.Enabled = x;
            btn1.Enabled = x;
            btn2.Enabled = !x;
            btn3.Enabled = !x;
            btn4.Enabled = !x;
            btn5.Enabled = !x;
            btn6.Enabled = !x;
            btn7.Enabled = !x;
            btn8.Enabled = !x;
            btn9.Enabled = !x;
            if (x == false)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
            }
        }

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            operador = "";
            valor1 = 0.0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            int contar = 0;
            string display = lblDisplay.Text;
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i] == ',')
                    contar++;
            }
            if (contar == 0)
                lblDisplay.Text = lblDisplay.Text + ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Double v2 = Double.Parse(lblDisplay.Text);
            Double r = calc.Calcular(valor1, v2, operador);
            lblDisplay.Text = r.ToString();
            valor1 = 0.0;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            { 
            operador = "+";
            valor1 = double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            }
            catch (Exception erro) { }
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calc.mSeno(lblDisplay.Text);
        }

        private void rdoBinario_Click(object sender, EventArgs e)
        {
            mostrarBotoesBinario(true);
            try
            {
                lblDisplay.Text = calc.mBin(lblDisplay.Text);
            }
            catch (Exception erro) { }
        }

        private void rdoDecimal_Click(object sender, EventArgs e)
        {
            mostrarBotoesBinario(false);
            try
            {
                lblDisplay.Text = calc.mDec(lblDisplay.Text);
            }catch(Exception er) { }
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(lblDisplay.Text);
            v = v * -1;
            lblDisplay.Text = "" + v;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            String x = lblDisplay.Text;
            x = x.Substring(0, x.Length - 1);
            lblDisplay.Text = x;
            if(x == "")
            {
                operador = "";
                valor1 = 0.0;
                lblDisplay.Text = "0";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = calc.mCos(lblDisplay.Text);

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
            }
            catch (Exception erro) { }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "*";
                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
            }
            catch (Exception erro) { }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "/";
                valor1 = double.Parse(lblDisplay.Text);
                lblDisplay.Text = "";
            }
            catch (Exception erro) { }
        }
    }
}
