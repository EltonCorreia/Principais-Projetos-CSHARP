using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04062024
{
    public partial class Form2 : Form
    {

        Receber x = new Receber();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviarReceber_Click(object sender, EventArgs e)
        {

            txtMensagemReceber.Text = x.getMensagem();

        }
    }
}
