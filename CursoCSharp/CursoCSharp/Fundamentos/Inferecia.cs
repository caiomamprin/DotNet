using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferecia
    {
        public static void Executar()
        {
            //Atribuindo0 valor por Inferecia. Ele substitui o var por string nesse caso.
            var nome = "Caio Henrique";


            //A linha seguinte daria erro de conversão.
            // nome = 123;
            Console.WriteLine(nome);
        }
    }
}
