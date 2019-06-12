using System;
using System.Collections.Generic;

namespace ProjetoWeb.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
       
        public DateTime DataNascimento { get; set; }

        public IList<Familia> Familias { get; set; }
        public Documentos Documentos { get; internal set; }
    }
}
