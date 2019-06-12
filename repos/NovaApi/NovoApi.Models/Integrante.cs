using System;
using System.Collections.Generic;
using System.Text;

namespace NovoApi.Models
{
    public class Integrante : Pessoa
    {
        public int TotalFaltas { get; set; }
        public int TotalPresencas { get; set; }
        public bool FezTrabalho { get; set; }

    }
}
