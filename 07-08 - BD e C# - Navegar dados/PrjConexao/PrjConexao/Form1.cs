using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjConexao
{
    public partial class Form1 : Form
    {

        ClasseConexao con;
        DataTable dt;

        int pos = 0;
        int quantidade = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);

            quantidade = dt.Rows.Count;
            //MessageBox.Show(dt.Rows[2][0].ToString());

            mostrarDados(0);
        }

        private void mostrarDados(int pos)
        {
            txtID.Text = dt.Rows[pos]["id"].ToString();
            txtNome.Text = dt.Rows[pos]["Nome"].ToString();
            txtFone.Text = dt.Rows[pos]["Fone"].ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            consultarDados("select * from contatos1");
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos >= quantidade - 1)
                pos = quantidade-1;
            mostrarDados(pos);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
                pos = 0;
            mostrarDados(pos);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarDados(pos);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pos = quantidade-1;
            mostrarDados(pos);
        }
    }
}
