using static System.Console;
namespace NullPropagationOperator
{
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "sem nome";
        public Curso Curso { get; set; }
    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string NomeCurso { get; set; } = "sem nome";
        public Area Area { get; set; }
    }

    public class Area
    {
        public string NomeArea { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno() {
                Matricula = 123,
                Nome = "Guinther",
                Curso = new Curso() {
                    NomeCurso = "Sistemas de Informação",
                    Area = new Area() { NomeArea = "Ciências Exatas" }
                }
            };
            WriteLine($"Matricula:{gp.Matricula}\nNome:{gp.Nome}");
            WriteLine($"Curso:{gp?.Curso?.NomeCurso ?? "Sem Curso"}");
            WriteLine($"Área:{gp?.Curso?.Area?.NomeArea ?? "Sem Área"}");
            ReadLine();
        }
    }
}
