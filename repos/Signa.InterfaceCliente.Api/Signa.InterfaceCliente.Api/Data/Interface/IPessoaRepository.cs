using System.Collections.Generic;
using Signa.InterfaceCliente.Api.Models;
using Signa.InterfaceCliente.Api.Data.Entities;

namespace Signa.InterfaceCliente.Api.Data.Interface
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
