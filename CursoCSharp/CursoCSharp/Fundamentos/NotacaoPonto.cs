using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //o Resultado de um passa para o outro usando a notação "."
            var saudacao = "Olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            
            //Console.WriteLine(valorImportante.Length); Linha com erro por variável estar nulo
            
              //SÓ ACESSO O LENGTH DA VARIÁVEL SE NÃO FOR NULA, Se não daria erro
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
