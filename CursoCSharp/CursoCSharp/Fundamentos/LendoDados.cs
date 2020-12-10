using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            //CultureInfo do globalization, InvariantCulture ele ignora o separador do SO, mesmo se eu digitar com "." ,ele lê corretamente
            Console.WriteLine("Qual o seu salário ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O {nome} tem {idade} anos e recebe {salario} de salário.");

        }
    }
}
