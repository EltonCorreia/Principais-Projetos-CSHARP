using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJLogin
{
    public partial class FRMLogin : Form
    {
        ClasseConexao con;
        DataTable dt;
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMostrarSenha.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void FRMLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifierKeys == Keys.Alt || ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String u = txtUsuario.Text;
            String s = txtSenha.Text;

            con = new ClasseConexao();
            string login = "SELECT * FROM contatos WHERE nome = '"+u+"' AND senha = '"+s+"'";

            dt = con.executarSQL(login);

            if (dt.Rows.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }
    }
}
