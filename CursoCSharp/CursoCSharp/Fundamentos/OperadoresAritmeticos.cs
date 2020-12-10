using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            double numero = 2;

            Console.WriteLine($"Soma: {numero + numero }");
            Console.WriteLine($"Subtração: {numero - numero}");
            Console.WriteLine($"Múltiplicação: {numero * numero}");
            Console.WriteLine($"Divisão: {numero / numero}");
            Console.WriteLine($"Mod: {numero % numero}");
        }
    }
}
