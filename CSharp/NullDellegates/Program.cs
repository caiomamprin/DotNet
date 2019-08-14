using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteLine("Informe valor do pedido:");
      var valor = ToDouble(ReadLine());
      var pedido = new Pedido();
      pedido.Pagar += v => WriteLine($"Pago valor de {v} no boleto");
      pedido.Fechar(valor);
      ReadLine();
    }

    //private static void Pedido_Pagar(double valor)
    //{
    //  WriteLine($"Pago valor de {valor} no boleto");
    //}
  }
}
