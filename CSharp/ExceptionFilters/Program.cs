using System;
using static System.Console;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 999999999;
            int Y = 0;
            var R1 = 0;
            int R2 = 0;
            try
            {
                R1 = X / Y;
                WriteLine($"{X} dividido por {Y} é igual a {R1}");
                R2 = checked(X * Y);
                WriteLine($"{X} multiplicado por {Y} é igual a {R2}");
            }
            //catch (DivideByZeroException E)
            //{
            //    WriteLine($"Mensagem:{E.Message}");
            //}
            //catch (OverflowException E)
            //{
            //    WriteLine($"Mensagem:{E.Message}");
            //}
            //catch (ArithmeticException E)
            //{
            //    WriteLine($"Erro aritmético:{E.Message}");
            //}
            catch (Exception E) when (E.Message.ToUpper().Contains("ESTOURO")) 
            {
                WriteLine($"Mensagem:{E.Message}");
            }
            catch (Exception E) when (E.Message.ToUpper().Contains("ZERO"))
            {
                WriteLine($"Mensagem:{E.Message}");
            }
        }
    }
}
