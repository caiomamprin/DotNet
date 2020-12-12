using System;

namespace CursoCSharp
{
    public class DelegatesComoParametros
    {
        public delegate double Operacao(double x, double y);

        public static double Soma(double x, double y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, double x, double y)
        {
          
            return $"Resultado: {op(x, y)}";
        }

        public static void Executar()
        {

            Console.WriteLine(Calculadora(Soma, 3, 2));


            Operacao subtracao = (double x, double y) => x - y;

            Console.WriteLine(Calculadora(subtracao, 5, 2));
            
        }
    }
}