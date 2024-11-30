using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjJogoDados
{
    public class Sortear
    {

        public int sorteio()
        {
            Random rd = new Random();
            int num = rd.Next(6);
            return num;
        }

    }
}
