using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(7);
            pilha.Push(true);
            pilha.Push(3.14f);
            pilha.Push(3.14);

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
            
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Count);

            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Count);


            

        }




    }
}
