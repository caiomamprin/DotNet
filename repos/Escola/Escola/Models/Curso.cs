using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Escola.Models
{
    public class Curso
    {
        public string Disciplina { get; set; }
        public int CodDisciplina { get; set; }
        public Aluno alunos;

    }
}
