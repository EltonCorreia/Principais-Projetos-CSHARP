using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29052024
{
    public class Receber
    {

        private static String nome;

        private static String sobrenome;

        public void setNome(String n)
        {
            nome = n;
        }

        public string getNome()
        {
            return nome;
        }

        //------------------------------

        public void setSobrenome(String s)
        {
            sobrenome = s;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

    }
}
