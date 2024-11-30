using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01062024
{
    //Colocar a classe como "public"
    public class Receber
    {

        //Criar um método "private"

        private static String nome;
        private static String idade;
        private static String hobby;

        //Criar os métodos "get" e "set"

        //Nome (public void)
        public void setNome(String n)
        {

            nome = n;

        }

        //Nome (public string)
        public string getNome()
        {

            return nome;

        }

        //Idade (public void)
        public void setIdade(String i)
        {

            idade = i;

        }

        public string getIdade()
        {

            return idade;

        }

        //Hobby (public void)
        public void sethobby(String h)
        {

            hobby = h;

        }

        public string gethobby()
        {

            return hobby;

        }

    }

}
