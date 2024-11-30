using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_avaliativa___DS3
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
            txtDescricao.Text = dt.Rows[pos]["descricao"].ToString();
            txtLugar.Text = dt.Rows[pos]["lugar"].ToString();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String i1 = txtDescricao.Text;
            String i2 = txtLugar.Text;

            con = new ClasseConexao();
            con.executarSQL("insert into f1 values('"+i1+"','"+i2+"')");
            MessageBox.Show("Incluído com sucesso!");

            consultarDados("select * from f1");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String e1 = txtID.Text;

            con = new ClasseConexao();
            con.executarSQL("delete from f1 where id='"+e1+"'");
            MessageBox.Show("Excluído com sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            String a1 = txtID.Text;
            String a2 = txtDescricao.Text;
            String a3 = txtLugar.Text;

            con = new ClasseConexao();
            con.executarSQL("update f1 set descricao = '"+a2+"', lugar ='"+a3+"' where id='"+a1+"'");
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultarDados("select * from f1");
        }
    }
}
