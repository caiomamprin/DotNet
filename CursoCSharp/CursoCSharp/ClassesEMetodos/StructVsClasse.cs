using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }

        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1 , Y = 2 };
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3; // ATRIBUIÇÃO POR VALOR

            Console.WriteLine($"Ponto1 X =  {ponto1.X}");
            Console.WriteLine($"CopiaPonto1 X = { copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 1, Y = 2 };
            CPonto copiaPonto2 = ponto2;
            ponto1.X = 3; // ATRIBUIÇÃO POR REFERÊNCIA

            Console.WriteLine($"Ponto1 X =  {ponto2.X}");
            Console.WriteLine($"CopiaPonto1 X = { copiaPonto2.X}");



        }
    }
}
