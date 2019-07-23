using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            //Nullable
            int? i = null;
            string s = null;

            var valores = new[] { new { idade = 18, nome = "Luis" }, new { idade = 20, nome = "Alberto" } };

            foreach (var item in valores)
            {
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
            
        }
    }
}
