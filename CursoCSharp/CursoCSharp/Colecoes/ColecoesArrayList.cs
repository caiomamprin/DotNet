using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {

        public static void Executar()
        {
            //EMBORA SEJA UMA BOA PRÁTICA NÃO TER UM ARRAY HETEREOGÊNEO, É POSSIVEL CASO EM ALGUM CENÁRIO SEJA BOM FAZER!
            ArrayList array = new ArrayList{
            "teste",
            2,
            true
            };

            array.Add(3.5);

            foreach( var item in array)
            {
                Console.WriteLine("{0} => {1}", item , item.GetType());
            }
        }
    }
}
