using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradutorArrayList
{
    public partial class Form1 : Form
    {

        List<string> lst = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lst.Add("Dog");

        }

        private void btnTraduzir_Click(object sender, EventArgs e)
        {

        }
    }
}
