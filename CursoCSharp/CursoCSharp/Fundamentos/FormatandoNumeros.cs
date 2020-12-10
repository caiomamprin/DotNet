using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;

            //UMA CASA DECIMAL
            Console.WriteLine(valor.ToString("F1"));

            //VALOR DE MONETÁRIO
            Console.WriteLine(valor.ToString("C"));

            //PERCENTUAL - COLOCANDO PERCENTUAL E MULTIPLICA POR 100
            Console.WriteLine(valor.ToString("P"));

            //ELE FAZ O ARREDONDAMENTO NESSE CASO .175 PARA .18
            Console.WriteLine(valor.ToString("#.##"));

            //coloca no formato de reais
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura));

            //Preenche com 0 a esquerda até dar 10 caracteres
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));




        }
    }
}
