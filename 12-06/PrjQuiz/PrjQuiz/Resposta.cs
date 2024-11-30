using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjQuiz
{
    public partial class Resposta : Form
    {
        Ponte cp = new Ponte();

        public Resposta()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //int resultado = cp.getContar();
            //lblResult.Text = resultado.ToString() + "/10";

            int contar = 0;

            String q1 = cp.getQ1();
            String q2 = cp.getQ2();
            String q3 = cp.getQ3();
            String q4 = cp.getQ4();
            String q5 = cp.getQ5();
            String q6 = cp.getQ6();
            String q7 = cp.getQ7();
            String q8 = cp.getQ8();
            String q9 = cp.getQ9();
            String q10 = cp.getQ10();

            if (q1 == "s")
            {
                contar++;
            }
            if (q2 == "s")
            {
                contar++;
            }
            if (q3 == "s")
            {
                contar++;
            }
            if (q4 == "s")
            {
                contar++;
            }
            if (q5 == "s")
            {
                contar++;
            }
            if (q6 == "s")
            {
                contar++;
            }
            if (q7 == "s")
            {
                contar++;
            }
            if (q8 == "s")
            {
                contar++;
            }
            if (q9 == "s")
            {
                contar++;
            }
            if (q10 == "s")
            {
                contar++;
            }

            lblResult.Text = contar + "/10";
        }
    }
}
