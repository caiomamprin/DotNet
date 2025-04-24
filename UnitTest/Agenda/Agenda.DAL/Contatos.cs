using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Agenda.Domain;
using Dapper;


namespace Agenda.DAL
{
    public class Contatos
    {
        string _strConnection; 

        public Contatos() 
        {
            _strConnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }

        public void Adicionar(Contato contato)
        {
            using (var con = new SqlConnection(_strConnection))
            {
                con.Execute("insert into Contato (Id,Nome) values (@Id, @Nome)", contato);
                
            }
        }

        public Contato Obter(Guid id)
        {
            Contato contato;

            using (var con = new SqlConnection(_strConnection))
            {
                contato = con.QueryFirst<Contato>("SELECT Id, Nome FROM Contato where Id = @Id", new {Id = id});
            }
            return contato;
            
        }

        public List<Contato> ObterTodos()
        {
           
            var contatos = new List<Contato>();
            using (var con = new SqlConnection(_strConnection))
            {
                contatos = con.Query<Contato>("SELECT Id, Nome FROM Contato").ToList();
            
            }
            return contatos;

        }
    }
}
