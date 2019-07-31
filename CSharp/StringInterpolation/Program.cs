using static System.Console;
using static System.DateTime;

namespace StringInterpolation
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa() {
                Matricula = 123,
                Nome = "Guinther",
                SobreNome = "Pauli" };
            // WriteLine("Bem-vindo " + p.Nome + " " + p.SobreNome + "(" +
            // p.Matricula + "), este é o C# 6");
            //WriteLine(string.Format("Bem-vindo {0} {1} ({2}), este é o C# 6",
            //p.Nome, p.SobreNome, p.Matricula));
            WriteLine($"Bem-vindo {p.Nome, 10} de B. {p.SobreNome, 10} ({p.Matricula}), este é o C# 6");
            WriteLine($"Olá, agora são {Now.ToLongTimeString()}");
            ReadLine();
        }
    }
}
