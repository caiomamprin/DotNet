using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Pedro";
            a1.Idade = 30;

            Aluno a2 = new Aluno();
            a2.Nome = "Lauro";
            a2.Idade = 18;

            Aluno a3 = new Aluno("Alberto", 25);


            Console.WriteLine(a1.GetTwiceIdade());
            Console.ReadKey();
            a1.Limpar();

            
        }
    }
}
