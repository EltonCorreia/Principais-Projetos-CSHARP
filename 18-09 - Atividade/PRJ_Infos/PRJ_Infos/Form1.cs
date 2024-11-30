using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_Infos
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

            mostrarDados(0);
        }
        private void mostrarDados(int pos)
        {
            txtID.Text = dt.Rows[pos]["id"].ToString();
            txtData.Text = dt.Rows[pos]["data"].ToString();
            txtNome.Text = dt.Rows[pos]["nome"].ToString();
            txtValor.Text = dt.Rows[pos]["valor"].ToString();
            txtFone.Text = dt.Rows[pos]["fone"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultarDados("select * from contatos");
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarDados(pos);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pos = quantidade - 1;
            mostrarDados(pos);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
                pos = 0;
            mostrarDados(pos);
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos >= quantidade - 1)
                pos = quantidade - 1;
            mostrarDados(pos);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String i1 = txtNome.Text;
            String i2 = txtFone.Text;
            String i3;
            String i4 = txtData.Text;
            String i5 = txtValor.Text;

            if (cbAtivoPassivo.Checked)
            {
                i3 = "A";
            }
            else
            {
                i3 = "B";
            }

            i5 = i5.Replace(",", ".");

            con = new ClasseConexao();
            String sql = "insert into contatos values('" + i1 + "','" + i2 + "','" + i3 + "','" + i4 + "'," + i5 + ")";
            MessageBox.Show(sql);
            con.executarSQL(sql);
            MessageBox.Show("Incluído com sucesso!");

            //consultarDados("select * from contatos");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            String a0 = txtID.Text;
            String a1 = txtNome.Text;
            String a2 = txtData.Text;
            String a3 = txtValor.Text;
            String a4 = txtFone.Text;

            con = new ClasseConexao();
            con.executarSQL("update contatos set nome = '"+a1+"', data = '"+a3+"', valor = '"+a3+ "',fone = '"+a4+"' where id='"+a0+"'");
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String d1 = txtID.Text;

            con = new ClasseConexao();
            con.executarSQL("delete from contatos where id='"+d1+"'");
            MessageBox.Show("Excluído com sucesso!");
        }
    }
}
