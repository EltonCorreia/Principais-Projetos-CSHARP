using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___Estudo
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //Declaração das variáveis:

        string total;
        Double num1;
        Double num2;
        string opcao;
        Double resultado;

        //Botões numerais e operações:

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_visor.Text += "9";
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            opcao = "+";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            opcao = "-";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            opcao = "*";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            opcao = "/";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_seno_Click(object sender, EventArgs e)
        {
            opcao = "sen";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            opcao = "cos";
            num1 = Double.Parse(txt_visor.Text);

            txt_visor.Clear();
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            opcao = "tan";
            

            txt_visor.Clear();
        }

        //Operações com "if" e "Equals":

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(txt_visor.Text);

            if (opcao.Equals("+"))
                resultado = num1 + num2;

            if (opcao.Equals("-"))
                resultado = num1 - num2;

            if (opcao.Equals("*"))
                resultado = num1 * num2;

            if (opcao.Equals("/"))
                resultado = num1 / num2;

            if (opcao.Equals("sen"))
                resultado = Math.Sin(num1 * (Math.PI / 180));

            if (opcao.Equals("cos"))
                resultado = Math.Cos(num1 * (Math.PI / 180));

            if (opcao.Equals("tan"))
                resultado = Math.Tan(num1 * (Math.PI / 180));

            txt_visor.Text = resultado + "";
        }

        //Botão apagar:

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_visor.Clear();
            resultado = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
