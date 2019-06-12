namespace Loja.Domain
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        //Coluna para Chave Estrangeira
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}

