using System;
using static System.Console;

namespace NameOfOperator
{
    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "sem nome";
        public DateTime Data { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"Matricula:{Matricula},Nome:{Nome},Data:{Data}";
        }
    }

    public static class Relatorio
    {
        public static void Imprimir(Professor prof)
        {
            WriteLine("Relatório:");
            WriteLine(prof?.ToString() ?? 
                $"O parâmetro de nome {nameof(prof)} não pode ser nulo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor GBP = null;
            Relatorio.Imprimir(GBP);
            WriteLine(GBP?.ToString() ?? $"Objeto {nameof(GBP)} não instanciado");
            GBP = new Professor() { Matricula = "123", Nome = "Guinther" };
            WriteLine(GBP);
            Relatorio.Imprimir(GBP);
        }
    }
}
