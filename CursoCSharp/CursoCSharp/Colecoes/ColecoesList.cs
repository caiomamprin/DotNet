using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesList
    {

        public class Produto
        {
            public string Nome;

            public double Preco;

            public Produto(string nome , double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj)
            {
                Produto outroProduto = (Produto)obj;

                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;

                return mesmoNome && mesmoPreco;

            }

            public override int GetHashCode()
            {
                return Nome.Length;
            }

        }
        public static void Executar()
        {
            var livro = new Produto("Code Clean", 200.00);
                
            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);

            var combo = new List<Produto>
            {
                new Produto("Iphone X", 10000.00),
                new Produto("Smart Watch", 4000.00),
                new Produto("Fone bluetooth", 999.99)
            };

            //metodo p/ Add uma lista de itens de uma vez, sem precisar de um for
            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);

            var resultado = carrinho.LastIndexOf(livro);

            if (resultado != 0)
            {
                Console.WriteLine("Encontrou: " + resultado);
            }
            
            carrinho.RemoveAt(carrinho.Count -1);
            Console.WriteLine(carrinho.Count);

            //permite Add o mesmo elemento            
            
            carrinho.Add(livro);


            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"Item: {item.Nome} - Preço {item.Preco}");
            }
        }
    }
}
