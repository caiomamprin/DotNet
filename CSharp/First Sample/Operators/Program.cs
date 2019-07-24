using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sintaxe

            int a = 10;
            int b = 2;
            //Aritmeticos

            //Add
            int add = a + b;

            //Subt
            int subt = a - b;

            //Mult
            int mult = a * b;

            //Divis
            int divis = a / b;

            //Rest
            int rest = 5 % 2;


            //Primary

            //incremento - x++
            //decremento - x--

            //Comparativos
            /*
            if (a > b)
            //  Console.WriteLine("a > b");

            if (b < a)
            // Console.WriteLine("b < a");

            // => - Lambda
            if (a >= b)
            // Console.WriteLine("a >= b");

            if (b <= a)
            // Console.WriteLine("b <= a");

            //Equals
            if (a == b)
            // Console.WriteLine("a == b");

            //Not
            if (a != b)
            // Console.WriteLine("a != b");

            //Logicos
            //XOR - Lógico Exclusivo - Um ou outro
            if (true ^ false)
            //Console.WriteLine("true");

            //Condicionais

            //AND
            if (true && true)
            //Console.WriteLine("true");

            //OR --> if(a < b || b > c)
            if (false || true)
                //Console.WriteLine("true");
            */

            #endregion


            Console.WriteLine("Valor 1: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int v2 = int.Parse(Console.ReadLine());


            //Operators Aritmetics
            Console.WriteLine();
            Console.WriteLine("Soma: " + Convert.ToString(v1 + v2));
            Console.WriteLine("Subtração: " + Convert.ToString(v1 - v2));
            Console.WriteLine("Multiplicação: " + Convert.ToString(v1 * v2));
            Console.WriteLine("Divisão: " + Convert.ToString(v1 / v2));
            Console.WriteLine();

            //Operators Logics
            if (v1 > 0 && v2 > 0)
                Console.WriteLine("Valores v1 e v2 Maiores que Zero");

            if (v1 + v2 <= 0 || v1 - v2 <= 0 || v1 * v2 <= 0 || v1 / v2 <= 0)
                Console.WriteLine("Uma ou mais operações possuem valor Menor ou Igual a Zero");


            Console.ReadKey();


        }
    }
}
