using static System.Console;

namespace AutoPropertyInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno(); // { Matricula = 123, Nome = "Guinther" };
            WriteLine($"{ Aluno.Matricula} - {gp.Nome} - {gp.Status}");
            ReadLine();
        }
    }
}
