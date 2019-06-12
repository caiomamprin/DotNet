using System;
using System.Collections.Generic;
using System.Text;

namespace NovoApi.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Descricao { get; set; }

        public IList<Palestrante> Palestrantes { get; set; }
        public IList<Integrante> Integrantes { get; set; }

    }
}
