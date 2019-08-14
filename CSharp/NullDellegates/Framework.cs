using System;
using static System.Console;

namespace Exemplo
{
  //public class Boleto
  //{
  //  public void Pagar(double valor)
  //  {
  //    WriteLine($"Pago valor de {valor} no boleto");
  //  }
  //}

  public delegate void PagarEvent(double valor);

  public class Pedido
  {
    // Boleto boleto = new Boleto();
    public event PagarEvent Pagar;

    public void Fechar(double valor)
    {
      // delegação com delegate / event
      Pagar?.Invoke(valor);
    }  
  }
}
