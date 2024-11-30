using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Controler.ClasseControleContatos yy = new Controler.ClasseControleContatos();
            yy.buscardados("select * from contatos");
            Model.ClasseContatos ct = new Model.ClasseContatos();
            textBox1.Text = ct.getNome();
        }
    }
}
