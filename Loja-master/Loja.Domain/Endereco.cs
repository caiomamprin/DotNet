namespace Loja.Domain
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //Chave Estrangeira de Funcionario
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
