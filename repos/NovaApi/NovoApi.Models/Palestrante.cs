using System;
using System.Collections.Generic;
using System.Text;

namespace NovoApi.Models
{
    public class Palestrante : Pessoa
    {

        public IList<string> Skills { get; set; }
    }
}
