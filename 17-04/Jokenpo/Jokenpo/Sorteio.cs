using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public class Sorteio
    {
        public int sorteio()
        {
            Random rd = new Random();
            int num = rd.Next(3);
            return num;
        }
    }
}
