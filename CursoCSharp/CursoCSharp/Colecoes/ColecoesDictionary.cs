using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(1, "O Poderoso Chefão");
            filmes.Add(2, "O Poderoso Chefão 2");
            filmes.Add(3, "O Poderoso Chefão 3");

            Console.WriteLine(filmes.ContainsValue("O Poderoso Chefão"));

            if (filmes.ContainsKey(1))
            {
                Console.WriteLine($"01: {filmes.GetValueOrDefault(1)}");
            }

            Console.WriteLine($"Removeu? {filmes.Remove(3)}");

            filmes.TryGetValue(2, out string descricaoFilme);
            Console.WriteLine($"O filme capturado é: {descricaoFilme}");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine($"Código do filme: {chave}");
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine($"Código do filme: {valor}");
            }

            foreach(var filme in filmes)
            {
                Console.WriteLine($"Cod: {filme.Key} - Descrição: {filme.Value}");
            }

        }
    }
}
