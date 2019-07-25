namespace TratamentoDeExcecoes
{
    public class Atendimento
    {
        public int Codigo { get; set; }
        public decimal Total { get; set; }
        public int QuantidadePessoas { get; set; }
        public decimal TotalPorPessoa
        {
            get
            {
                return Total / QuantidadePessoas;
            }
        }

        public override string ToString()
        {
            return $"Código: {Codigo} \n Total: {Total} \n Pessoas: {QuantidadePessoas} \n Total por pessoa: {TotalPorPessoa}";
        }
    }
}
