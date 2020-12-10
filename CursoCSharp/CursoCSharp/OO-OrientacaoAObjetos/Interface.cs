using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO_OrientacaoAObjetos
{
    public class Interface
    {
        interface OperacaoBinaria
        {
            double Operacao(double a, double b);
        }

        public class Soma : OperacaoBinaria
        {
            public double Operacao(double a, double b)
            {
                return a + b;
            }
        }

        public class Subtracao : OperacaoBinaria
        {
            public double Operacao(double a, double b)
            {
                return a - b;
            }
        }

        public class Multiplicacao : OperacaoBinaria
        {
            public double Operacao(double a, double b)
            {
                return a * b;
            }
        }

        public class Calculadora
        {
            List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
            {
                new Soma(),
                new Subtracao(),
                new Multiplicacao()
            };

            public string ExecutarOperacoes(double a, double b)
            {
                string resultado = "";

                foreach(var operacao in operacoes)
                {
                    resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(a, b)}\n";
                }

                return resultado;
            }

        }


        public static void Executar()
        {

            Calculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.ExecutarOperacoes(2, 5)); 
        
        }
    }
}
