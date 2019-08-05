using System.Collections.Generic;
using static System.Console;

namespace CollectionIndexInitializer
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        //public Aluno(string nome)
        //{
        //    this.Nome = nome;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Alunos = new Dictionary<string, Aluno>()
            {
                ["GP"] = new Aluno() { Nome = "Guinther", SobreNome = "Pauli" },
                ["RP"] = new Aluno() { Nome = "Rudolfo", SobreNome = "Pauli" },
                ["RS"] = new Aluno() { Nome = "Rodrigo", SobreNome = "Silva" }
            };
            WriteLine("Informe chave");
            var index = ReadLine();
            WriteLine($"Aluno:{Alunos[index].Nome} {Alunos[index].SobreNome}");


            //var a1 = new Aluno() { Nome = "Guinther", SobreNome = "Pauli" };
            //var a2 = new Aluno() { Nome = "Rudolfo", SobreNome = "Pauli" };
            //var a3 = new Aluno() { Nome = "Rodrigo", SobreNome = "Silva" };
            //var Alunos = new Dictionary<int, Aluno>()
            //{
            //    { 123, a1 },
            //    { 456, a2 },
            //    { 789, a3 }                
            //};
            //Alunos.Add(1, new Aluno() { Nome = "Guinther", SobreNome = "Pauli" });
            //Alunos.Add(2, new Aluno() { Nome = "Rudolfo", SobreNome = "Pauli" });
            //var Alunos = new List<Aluno>()
            //{
            //    new Aluno() { Nome = "Guinther", SobreNome = "Pauli" },
            //    new Aluno() { Nome = "Rudolfo", SobreNome = "Pauli" }
            //};
            // Alunos.Add(new Aluno() { Nome = "Guinther", SobreNome = "Pauli" });
            //var a1 = new Aluno()
            //{
            //    Nome = "Guinther",
            //    SobreNome = "Pauli"
            //};
        }
    }
}
