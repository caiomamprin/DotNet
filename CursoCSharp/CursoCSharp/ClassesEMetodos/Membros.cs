using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            //USANDO O COSNTRUTOR PADRÃO
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");


            //USANDO O CONSTRUTOR DEFINIDO

            Pessoa p2 = new Pessoa("Caio Henrique", 28);

            Console.WriteLine($"{p2.Nome} tem {p2.Idade} anos.");


        }
    }
}
