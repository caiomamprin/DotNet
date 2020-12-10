using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {

            bool bomComportamento =  false;
            string entrada;

            Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possuí bom comportamento (S/N): ");
            entrada = Console.ReadLine();


            //if(entrada == "S" || entrada == 's')
            //    bomComportamento = true

            bomComportamento = entrada.ToLower() == "s";


            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }


            if( nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            if(nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra");
            }else if(nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            switch (nota)
            {
                case 10:
                    Console.WriteLine("Excelente");
                    break;
                case 9:
                    Console.WriteLine("Bom");
                    break;
                case 8:
                    Console.WriteLine("Bom");
                    break;
                case 7:
                    Console.WriteLine("Bom");
                    break;
                default:
                    Console.WriteLine("Reprovado");
                    break;

            }


        }
    }
}
