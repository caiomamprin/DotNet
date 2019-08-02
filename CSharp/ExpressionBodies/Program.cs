using System;
using static System.Console;

namespace ExpressionBodies
{
    public static class Calculadora
    {
        public static string Nome => "SuperCalc";
        public static int Somar(int X, int Y) => X + Y;
        //{
        //    return X + Y;
        //}
        public static int Multiplicar(int X, int Y) => X * Y;
        //{
        //    return X + Y;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            var r1 = Calculadora.Somar(x, y);
            WriteLine($"Usando a calculadora {Calculadora.Nome} Soma:{r1}");
            x = 3;
            y = 7;
            var r2 = Calculadora.Multiplicar(x, y);
            WriteLine($"Usando {Calculadora.Nome}, a multiplicação de {x} e {y} é {r2}");
        }
    }
}
