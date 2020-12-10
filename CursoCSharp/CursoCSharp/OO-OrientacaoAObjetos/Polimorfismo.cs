using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO_OrientacaoAObjetos
{
    class Polimorfismo
    {
        public class Comida
        {
            protected internal double Peso;

            public Comida(double peso)
            {
                Peso = peso;
            }

        }
        public class Arroz : Comida
        {
            public Arroz(double peso) : base(peso) { }
        }

        public class Feijao : Comida
        {
            public Feijao(double peso) : base(peso) { }
        }

        public class Carne : Comida
        {
            public Carne(double peso) : base(peso) { }
        }

        public class Pessoa
        {
            public double Peso;

            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }

        public static void Executar()
        {
            Pessoa cliente = new Pessoa();
            cliente.Peso = 65.0;

            Arroz prato1 = new Arroz(0.5);

            Feijao prato2 = new Feijao(0.3);

            cliente.Comer(prato1);
            cliente.Comer(prato2);

            Console.WriteLine($"Agora o peso do cliente é: {cliente.Peso}kg.");

        }
    }
}
