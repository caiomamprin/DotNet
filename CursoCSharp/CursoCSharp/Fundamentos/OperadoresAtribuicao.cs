using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; //num1 = num1 - 3;
            num1 *= 5; //num1 = num1 * 5;
            num1 /= 2; //num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1; // Atribuição literal
            int b = a; //Atribuição por cópia

            a++;
            b--;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //Atribuição por Referência (As duas variáveis apontam pro mesmo espaço alocal na memória
            //Alterando d , altera a c e vice-versa
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;

            d = "Maria";

            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
