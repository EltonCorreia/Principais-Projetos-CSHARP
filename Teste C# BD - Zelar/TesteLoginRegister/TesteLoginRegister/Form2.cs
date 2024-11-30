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
    public partial class Form2 : Form
    {

        ClasseConexao con;
        DataTable dt;

        public Form2()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(sql);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String user = txtRegisterUser.Text;
            String senha = txtRegisterSenha.Text;

            con = new ClasseConexao();
            con.executarSQL("INSERT INTO testelogin VALUES ('" + user + "','" + senha + "')");

            consultarDados("SELECT * FROM testelogin");

            MessageBox.Show("Registrado com sucesso!");
        }
    }
}
