using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //Como o double tem maior capacidade de armazenamento, ele faz a conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);


            //Conversão explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada {notaTruncada}");

            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");
        }
    }
}
