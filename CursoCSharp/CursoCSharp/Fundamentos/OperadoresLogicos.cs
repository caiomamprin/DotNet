using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho1;
            Console.WriteLine("Comprou a TV 50? {0}" , comprouTV50);

            bool comprouTV32 = executouTrabalho1 || executouTrabalho1;
            Console.WriteLine("Comprou a TV 32? {0}", comprouTV32);

            bool comprouSorvete = executouTrabalho1 ^ executouTrabalho1;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);



        }
    }
}
