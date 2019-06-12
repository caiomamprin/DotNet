using Dapper;
using System.Data;
using System.Collections.Generic;
using Signa.Default.Template1.Models;
using Signa.Default.Template1.Data.Entities;
using Signa.Default.Template1.Data.Interface;

namespace Signa.Default.Template1.Data.Repository
{
    public class PessoaRepository : RepositoryBase, IPessoaRepository
    {
        public IEnumerable<Pessoa> GetAll()
        {
            using (var db = Connection)
            {
                return db.Query<Pessoa>("Select Pessoa_Id, Nome, Nome_Fantasia, CnpjCpf = IsNull(Pj_Cgc, Pf_Cpf), Email " + _n +
                    "From Pessoa " + _n +
                    "Where Tab_Status_Id = 1");
            }
        }

        public Pessoa GetById(int id)
        {
            using (var db = Connection)
            {
                return db.QueryFirstOrDefault<Pessoa>("Sp_Ecr_Con_Pessoa_Template",
                    param: new { Pessoa_Id = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public bool Insert(PessoaModel pessoa)
        {
            using (var db = Connection)
            {
                var exec = db.Execute("Sp_Ecr_Inc_Pessoa_Template",
                    param: new
                    {
                        Nome = pessoa.PessoaNome,
                        NomeFantasia = pessoa.PessoaNomeFantasia,
                        CnpjCpf = pessoa.PessoaCnpjCpf,
                        Email = pessoa.PessoaEmail
                    },
                    commandType: CommandType.StoredProcedure);

                if (exec == 0)
                    return false;

                Helpers.LogHelper.GravaLogSistema(41, pessoa.PessoaId, 1, "Inclusão via Api de Pessoa", null);


                return true;

            }
        }

        public bool Update(PessoaModel pessoa)
        {
            using (var db = Connection)
            {
                var exec = db.Execute("Sp_Ecr_Inc_Pessoa_Template",
                    param: new
                    {
                        pessoa.PessoaId,
                        Nome = pessoa.PessoaNome,
                        NomeFantasia = pessoa.PessoaNomeFantasia,
                        CnpjCpf = pessoa.PessoaCnpjCpf,
                        Email = pessoa.PessoaEmail
                    },
                    commandType: CommandType.StoredProcedure);
                if (exec == 0)
                    return false;

                Helpers.LogHelper.GravaLogSistema(41, pessoa.PessoaId, 2, "Alteração via Api de Pessoa", null);

                return true;

            }
        }

        public bool Delete(int pessoaId)
        {
            using (var db = Connection)
            {
                var exec = db.Execute("Update Pessoa Set Tab_Status_Id = 2 Where Pessoa_Id = @Id",
                    param: new { Id = pessoaId });

                if (exec == 0)
                    return false;

                Helpers.LogHelper.GravaLogSistema(41, pessoaId, 3, "Exclusão via Api de Pessoa", null);

                return true;
            }
        }
    }
}