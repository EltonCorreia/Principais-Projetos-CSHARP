using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz3
{
    public class Ponte
    {
        private static String nome;

        private static int contador;

        public void setContar(int i) 
        {
            contador += i;
        }
        public int getContar()
        {
            return contador;
        }
        public void setNome(String v)

        {
            nome = v;
        }
        public String getNome() 
        {
            return nome;

        }

    }

}
