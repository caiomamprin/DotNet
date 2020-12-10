using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturasDeRepeticao
    {
        public static void Executar()
        {


            int count = 0;

            while( count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            do
            {
                Console.WriteLine(count);
                count--;
            } while (count != 0);


            for(int i = 20; i <= 30; i++)
            {
                Console.WriteLine(i);
            }

            string palavra = "teste!";

            foreach(var letra in palavra)
            {
                Console.Write(letra);
            }


            //BREAK / CONTINUE

            Random random = new Random();
            int numero = random.Next(1, 51);

            for (int i = 0; i <= 50; i++)
            {
                Console.Write("O número {0} é o sorteado? ");

                if(numero == i)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else{
                    Console.WriteLine("Não");
                }
            }

            int intervalo = 50;

            for (int i = 0; i <= intervalo; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }

           

        }
    }
}
