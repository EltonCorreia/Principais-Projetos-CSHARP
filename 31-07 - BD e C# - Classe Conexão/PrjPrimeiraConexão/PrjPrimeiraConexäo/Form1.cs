using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjPrimeiraConexäo
{
    public partial class Form1 : Form
    {

        ClasseConexao con;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL("select * from contatos1");
            //MessageBox.Show(dt.Rows[2][0].ToString());

            txtID.Text = dt.Rows[1][0].ToString();
            txtNome.Text = dt.Rows[0][1].ToString();
            txtFone.Text = dt.Rows[0][2].ToString();
        }
    }
}
