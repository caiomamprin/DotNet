using System;
using System.Collections.Generic;
using System.Linq;

namespace TratamentoDeExcecoes
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
            /*Trecho de Código que Gera excessão por não estar instanciado*/
        //public List<ItemVenda> Itens { get; } ;
        public List<ItemVenda> Itens { get; } = new List<ItemVenda>();

        public void AdicionarItem(ItemVenda item)
        {
            if (item == null)
                throw new VendaException(999, "O item não pode ser nulo");
            Itens.Add(item);
        }

        public decimal CalcularTotal()
        {
            return Itens.Sum(i => i.Preco * i.Quantidade);
        }
    }
}