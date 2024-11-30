using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjMVC.Controler
{
    public class ClasseControleContatos
    {
        ClasseConexao con;

        public void buscardados(String sql)
        {
            Model.ClasseContatos contatos = new Model.ClasseContatos();
            ClasseConexao conn = new ClasseConexao();
            DataTable dt = conn.executarSQL(sql);
            if (dt.Rows.Count > 0)
            {
                contatos.setID(dt.Rows[0]["id"].ToString());
                contatos.setNome(dt.Rows[0]["nome"].ToString());
                contatos.setFone(dt.Rows[0]["fone"].ToString());
            }
        }

        public void incluirContato(String nome,String fone)
        {
            con = new ClasseConexao();
            String sql = "INSERT INTO contatos VALUES('"+nome+"','"+fone+"')";
            con.executarSQL(sql);
        }
    }
}
