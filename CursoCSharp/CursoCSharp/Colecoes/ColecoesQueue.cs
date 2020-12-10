using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Caio");
            fila.Enqueue("Mariana");
            fila.Enqueue("Amarilis");
            fila.Enqueue("Lucila");
            fila.Enqueue("Fernando");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());

            //Aceita duplicados
            fila.Enqueue("Caio");

            foreach(var pessoa in fila) 
            {
                Console.WriteLine(pessoa);
            }


        }
        
    }
}
