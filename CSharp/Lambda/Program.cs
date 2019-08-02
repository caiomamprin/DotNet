using System;
using static System.Console;

namespace ExpressionBodies
{
    public delegate void PagarEvent (double valor);

    public class Pedido
    {
        public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            Pagar(valor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();
            pedido.Pagar += v => WriteLine($"Pago valor de {v}");
            pedido.Fechar(2000); 
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    WriteLine($"Pago valor de {valor}");
        //}
    }
}
