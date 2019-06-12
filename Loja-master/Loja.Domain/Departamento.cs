using System.Collections.Generic;

namespace Loja.Domain
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Funcionario> Funcionarios { get; set; }
    }
}
