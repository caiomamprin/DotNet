using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{

    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar()
        {

            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;

            Console.WriteLine($"Soma: {soma(10,10)}");
            Console.WriteLine($"Subtração: {subtracao(10,5)}");
            Console.WriteLine($"Multiplicação: {multiplicacao(10,4)}");

        }
    }
}
