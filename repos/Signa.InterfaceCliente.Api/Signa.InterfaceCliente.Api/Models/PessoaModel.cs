using System.ComponentModel.DataAnnotations;

namespace Signa.InterfaceCliente.Api.Models
{


    public class PessoaModel
    {
        public int PessoaId { get; set; }

        [MinLength(3, ErrorMessage = "Nome deve conter no mínimo 3 caracteres")]
        [MaxLength(40, ErrorMessage = "Nome deve conter no máximo 40 caracteres")]
        public string PessoaNome { get; set; }

        public string PessoaNomeFantasia { get; set; }

        [Required(ErrorMessage = "Informar Cnpj/Cpf.", AllowEmptyStrings = false)]
        public string PessoaCnpjCpf { get; set; }

        [EmailAddress(ErrorMessage = "O E-mail não é válido.")]
        [Required(ErrorMessage = "Informar Email.", AllowEmptyStrings = false)]
        public string PessoaEmail { get; set; }
    }
}