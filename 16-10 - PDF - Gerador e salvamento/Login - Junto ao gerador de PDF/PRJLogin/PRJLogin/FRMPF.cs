using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJLogin
{
    public partial class FRMPF : Form
    {
        ClasseConexao con;
        DataTable dt;
        public FRMPF()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            String u = txtCadastroUsuario.Text;
            String s = txtCadastroSenha.Text;
            SqlCommand cmd = new SqlCommand("INSERT INTO contatos (nome,senha) VALUES (@u,@s)");
            cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = u;
            cmd.Parameters.Add("@s", SqlDbType.NVarChar, 50).Value = s;
            int x = con.manutencaoDB_Parametros(cmd);
            if (x > 0)
            {
                MessageBox.Show("Registrado com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao registrar");
            }
        }

        private void FRMPF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String u = txtCadastroUsuario.Text;
            String s = txtCadastroSenha.Text;
            String id = txtID.Text;
            SqlCommand cmd = new SqlCommand
                ("UPDATE contatos SET nome=@u, senha=@s WHERE id=@id");
            cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = u;
            cmd.Parameters.Add("@s", SqlDbType.NVarChar, 50).Value = s;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            int x = con.manutencaoDB_Parametros(cmd);
            if (x > 0)
            {
                MessageBox.Show("Alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao alterar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String u = txtCadastroUsuario.Text;
            String s = txtCadastroSenha.Text;
            String id = txtID.Text;
            SqlCommand cmd = new SqlCommand
                ("DELETE FROM contatos WHERE id=@id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            int x = con.manutencaoDB_Parametros(cmd);
            if (x > 0)
            {
                MessageBox.Show("Excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao excluir");
            }
        }
    }
}
