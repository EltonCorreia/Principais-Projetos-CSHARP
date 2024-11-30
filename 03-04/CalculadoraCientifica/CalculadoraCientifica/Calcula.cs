using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCientifica
{
    public class Calcula
    {

        public String mBin(String v)
        {
                int n, r;
                String b = "";
                n = int.Parse(v);
                while (n > 0)
                {
                    r = n % 2;
                    n = n / 2;
                    if (r == 0)
                        b = "0" + b;
                    else
                        b = "1" + b;
                }
                return b;
        }

        public String mDec(String v)
        {

            int i, tamanho, n = 0;
            String texto = v;
            tamanho = texto.Length;
            for (i = 0; i <= (texto.Length) - 1; i++)
            {
                tamanho--;
                if (texto[i] == '1')
                    n = n + (int)Math.Pow(2, tamanho);
            }
            return (n).ToString();

        }

        public Double Calcular(Double v1, Double v2, String op)
        {

            Double t = 0.0;
            if (op.Equals("+"))
                t = v1 + v2;
            if (op.Equals("-"))
                t = v1 - v2;
            if (op.Equals("*"))
                t = v1 * v2;
            if (op.Equals("/"))
                t = v1 / v2;
            return t;

        }

        public String mSeno(String v)
        {

            double sin = double.Parse(v);
            return Math.Sin((sin * Math.PI) / 180) + "";

        }

        public String mCos(String v)
        {

            double cos = double.Parse(v);
            return Math.Cos((cos * Math.PI) / 180) + "";

        }

    }

}
