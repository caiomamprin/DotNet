using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if ( valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }

    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {


            Conta conta = new Conta(3_500.00);

            try
            {
                conta.Sacar(4_000.00);
                Console.WriteLine("Saque realizado com sucesso!");
            }
            catch (ArgumentException ex) //(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Exemplo de sessão encerrada!");
            }
        }
    }
}
