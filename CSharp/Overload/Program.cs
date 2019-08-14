using System;
using static System.Console;

namespace Exemplo
{
    public class Aluno: object
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Guinther";
        public override string ToString()
        {
            return $"Matrícula:{Matricula}-Nome:{Nome}";
        }
    }

    public class AlunoEspecial: Aluno
    {
        public string Situacao { get; set; } = "Especial";
        public override string ToString()
        {
            return $"Matrícula:{Matricula}-Nome:{Nome}-Situação:{Situacao}";
        }
    }


    class Program
    {
        static void Mostrar(string obj)
        {
            WriteLine($"Mostrar(string):{obj}");
        }

        static void Mostrar(int obj)
        {
            WriteLine($"Mostrar(int):{obj}");
        }

        static void Mostrar(bool obj)
        {
            WriteLine($"Mostrar(bool):{obj}");
        }

        static void Mostrar(object obj)
        {
            WriteLine($"Mostrar(object):{obj}");
        }

        static void Mostrar(Aluno obj)
        {
            WriteLine($"Mostrar(Aluno):{obj}");
        }

        static void Mostrar(AlunoEspecial obj)
        {
            WriteLine($"Mostrar(AlunoEspecial):{obj}");
        }

        static void Main(string[] args)
        {
            Mostrar("Ola Mundo");
            Mostrar(10);
            Mostrar(false);
            Mostrar(new Aluno());
            Mostrar(new AlunoEspecial() { Matricula = 123, Nome = "Pauli" });    
            ReadLine();
        }
    }
}
