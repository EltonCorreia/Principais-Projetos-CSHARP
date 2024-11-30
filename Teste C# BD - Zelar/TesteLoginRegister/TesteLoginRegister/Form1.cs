using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLoginRegister
{
    public partial class Form1 : Form
    {

        ClasseConexao con;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUser.Text;
            string senha = txtLoginSenha.Text;

            con = new ClasseConexao();
			string login = $"SELECT * FROM testelogin WHERE usuario = '{usuario}' AND senha = '{senha}'";

            DataTable dt = con.executarSQL(login);

            if (dt != null && dt.Rows.Count > 0)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
