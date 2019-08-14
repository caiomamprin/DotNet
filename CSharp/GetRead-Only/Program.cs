using System;
using static System.Console;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      var c = new Conta()
      {
        Cliente = "Guinther"
      };
      c.Depositar(2000);
      // c.Saldo = 1000000;
      WriteLine($"Prezado {c.Cliente}, seu saldo é {c.Saldo}");
      ReadLine();
    }
  }
}
