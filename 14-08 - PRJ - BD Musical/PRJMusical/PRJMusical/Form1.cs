using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJMusical
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
            txtDescricao.Text = dt.Rows[pos]["Descricao"].ToString();
            txtLocalizacao.Text = dt.Rows[pos]["Localizacao"].ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            consultarDados("select * from musica");
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String t1 = txtDescricao.Text;
            String t2 = txtLocalizacao.Text;

            con = new ClasseConexao();
            con.executarSQL("insert into musica values('"+t1+"','"+t2+"')");
            MessageBox.Show("Incluído com sucesso!");

            consultarDados("select * from musica");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            String d1 = txtID.Text;

            con = new ClasseConexao();
            con.executarSQL("delete from musica where id='"+d1+"'");
            MessageBox.Show("Excluído com sucesso!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String a1 = txtDescricao.Text;
            String a2 = txtID.Text;
            String a3 = txtLocalizacao.Text;

            con = new ClasseConexao();
            con.executarSQL("update musica set Descricao = '" +a1+ "', Localizacao = '"+a3+"' where id='" +a2+"'");
            MessageBox.Show("Atualizado com sucesso!");
        }
    }
}
