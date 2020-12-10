using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {

        
        public static void Executar()
        {
            var livro = new Produto("Code Clean", 200.00);
                
            //DIFERENTE DO LIST, O HASH NÃO É INDEXADO E NAO ACEITA REPETIÇÃO
            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);

            var combo = new HashSet<Produto>
            {
                new Produto("Iphone X", 10000.00),
                new Produto("Smart Watch", 4000.00),
                new Produto("Fone bluetooth", 999.99)
            };

            //metodo p/ Add uma lista de itens de uma vez, sem precisar de um for
            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);

            //var resultado = carrinho.LastIndexOf(livro);

                       
            //carrinho.RemoveAt(carrinho.Count -1);
            Console.WriteLine(carrinho.Count);

            //Não permite Add o mesmo elemento            
            
            carrinho.Add(livro);


            foreach (var item in carrinho)
            {

                Console.WriteLine($"Item: {item.Nome} - Preço {item.Preco}");
            }
        }
    }
}
