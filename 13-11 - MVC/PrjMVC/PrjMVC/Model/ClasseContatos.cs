using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjMVC.Model
{
    public class ClasseContatos
    {
        private static String id;
        public void setID(String v)
        {
            id = v;
        }
        public String getID()
        {
            return id;
        }

        //**********************************
        private static String nome;
        public void setNome(String v)
        {
            nome = v;
        }
        public String getNome()
        {
            return nome;
        }
        //***********************************
        private static String fone;
        public void setFone(String v)
        {
            id = v;
        }
        public String getFone()
        {
            return id;
        }
    }
}
