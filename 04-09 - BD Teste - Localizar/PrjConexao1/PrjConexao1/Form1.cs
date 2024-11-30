using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConexao1
{
    public partial class Form1 : Form
    {
        ClasseConexao con;
        DataTable dt;
        int pos = 0;
        int qtde = 0;
        Compartilha cp = new Compartilha();

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarDados(int pos)
        {
            textBox1.Text = dt.Rows[pos]["id"].ToString();
            textBox2.Text = dt.Rows[pos]["nome"].ToString();
            textBox3.Text = dt.Rows[pos]["fone"].ToString();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
            qtde = dt.Rows.Count;
            mostrarDados(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultarDados("select * from contatos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos >= qtde - 1)
            pos = qtde - 1;
            mostrarDados(pos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            pos = 0;
            mostrarDados(pos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarDados(pos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = qtde - 1;
            mostrarDados(pos);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FRMLocalizar frmLoc = new FRMLocalizar();
            frmLoc.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (cp.getId() != null)
            {
                con = new ClasseConexao();
                dt = new DataTable();

                String sql = "SELECT * FROM contatos WHERE id ="+cp.getId();
                dt = con.executarSQL(sql);
                qtde = dt.Rows.Count;
                mostrarDados(0);
            }
        }
    }
}
