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
            a1.Nome = "Caio Henrique Mamprin";
            a1.Idade = 27;

            Aluno a2 = new Aluno();
            a2.Nome = "Cristiano Ronaldo";
            a2.Idade = 28;
            Console.WriteLine(a2.Nome);

            //Inicializando o Objetando usando o Construtor para atribuir os valores
            Aluno a3 = new Aluno("Caio Henrique", 29);
            Console.WriteLine(a3.Nome);


            Console.WriteLine(a1.GetTwiceIdade());

            Console.WriteLine("Happy BirthDay " + a3.BirthDay().ToString());

            Console.ReadKey();
            a1.Limpar();

            
        }
    }
}
