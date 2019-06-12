using System.Collections.Generic;
using Signa.Default.Template1.Models;
using Signa.Default.Template1.Data.Entities;

namespace Signa.Default.Template1.Data.Interface
{
    interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa GetById(int pessoaId);
        bool Delete(int pessoaId);
        bool Update(PessoaModel pessoa);
        bool Insert(PessoaModel pessoa);
    }
}
