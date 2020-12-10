using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Propriedades
    {
        
        public class CarroOpcional
        {
            double desconto = 0.1;

            string nome;

            public string Nome
            {
                get
                {
                    return "Opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }

            //Propriedade AutoImplementada
            private double Preco { get; set; }

            //Somente Leitura
            public double PrecoComDesconto
            {
                // get => Preco - (desconto * Preco); lambda
                get
                {
                    return Preco - (desconto * Preco);
                }
            }


            public CarroOpcional(string nome , double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3.500);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.PrecoComDesconto);

        }
    }
}
