using System;

namespace CursoCSharp.MetodosEFuncoes
{
    public class UsandoDelegates
    {

        delegate double Soma(double x, double y);
        delegate void ImprimirSoma(double x, double y);
        public static void Executar()
        {
            static double MinhaSoma(double x, double y) 
            { 
                return x + y; 
            }
            static void MeuImprimirSoma(double x, double y)
            { 
                Console.WriteLine(x + y); 
            }

            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(10, 10));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(20, 20);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(30, 30));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(40, 40);

        }
    }
}