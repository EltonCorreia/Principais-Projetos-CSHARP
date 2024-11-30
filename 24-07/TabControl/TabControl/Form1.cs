using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        Info x = new Info();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            txtReceberNome.Text = x.getnome();
            txtReceberSobrenome.Text = x.getsobrenome();

        }

        private void BtnEnviar_Click_1(object sender, EventArgs e)
        {
            x.setnome(txtEnviarNome.Text);
            x.setsobrenome(txtEnviarSobrenome.Text);

            tabControl1.SelectedTab = tabPage2;

            txtEnviarNome.Text = "";
            txtEnviarSobrenome.Text = "";
        }
    }
}
