using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz3
{
    public partial class Final : Form
    {
        Ponte cp = new Ponte();
        public Final()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int resultado = cp.getContar();
            lblResultado.Text = resultado.ToString() + "/2";
        }
    }
}
