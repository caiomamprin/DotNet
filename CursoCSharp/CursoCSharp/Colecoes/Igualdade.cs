using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            Produto p1 = new Produto("Caneta", 2.0);
            Produto p2 = new Produto("Caneta", 2.0);

            //COMPARANDO ATRIBUTOS DOS OBJETOS
            Console.WriteLine(p1.Nome == p2.Nome);

            //SEM IMPLEMENTAR O MÉTODO EQUALS , ELE COMPARA O LOCAL DE MEMÓRIA, E NÃO OS VALORES DOS OBJETOS DANDO FALSE NA COMPARAÇÃO
            Console.WriteLine(p1.Equals(p2));


        }
    }
}
