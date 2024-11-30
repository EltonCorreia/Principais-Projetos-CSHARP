using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJabretelas
{
    public partial class Form2 : Form
    {
        Compartilha cp = new Compartilha();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cp.getNome());

            //this.Hide(); esconde
            //this.close(); fecha
           // this.Close();
        }
    }
}
