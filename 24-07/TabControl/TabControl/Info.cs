using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControl
{
    public class Info
    {
        private static String nome;
        private static String sobrenome;

        public void setnome(String n)
        {
            nome = n;
        }
        public String getnome()
        {
            return nome;
        }

        public void setsobrenome(String s)
        {
            sobrenome = s;
        }
        public String getsobrenome()
        {
            return sobrenome;
        }
    }
}
