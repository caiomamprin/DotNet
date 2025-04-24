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
                con.Open();

                var sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", contato.Id, contato.Nome);

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();
            }
        }

        public Contato Obter(Guid id)
        {
            Contato contato;

            using (var con = new SqlConnection(_strConnection))
            {
                con.Open();

                var sql = String.Format("SELECT Id, Nome FROM Contato where Id = '{0}';", id);


                SqlCommand cmd = new SqlCommand(sql, con);

                var sqlDataReader = cmd.ExecuteReader();
                sqlDataReader.Read();
                contato = new Contato()
                {
                    Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                    Nome = sqlDataReader["Nome"].ToString(),

                };
            }
            return contato;
            
        }

        public List<Contato> ObterTodos()
        {
            Contato contato;
            var contatos = new List<Contato>();
            using (var con = new SqlConnection(_strConnection))
            {
                con.Query<Contato>("SELECT Id, Nome FROM Contato").ToList();
                //contatos = new List<Contato>();
                //con.Open();

                //var sql = String.Format("SELECT Id, Nome FROM Contato;");


                //SqlCommand cmd = new SqlCommand(sql, con);

                //var sqlDataReader = cmd.ExecuteReader();
                //while (sqlDataReader.Read())
                //{
                    //contato = new Contato()
                    //{
                        //Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                        //Nome = sqlDataReader["Nome"].ToString(),
                    //};

                    //contatos.Add(contato);
                //}
            }
            return contatos;

        }
    }
}
