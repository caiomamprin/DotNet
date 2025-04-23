using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Agenda.Domain;


namespace Agenda.DAL
{
    public class Contatos
    {
        string _strConnection; 
        SqlConnection _con;

        public Contatos() 
        {
            _strConnection = @"Data Source =.\sqlexpress;Initial Catalog=Agenda;Integrated Security=True;";
            _con = new SqlConnection(_strConnection);
        }

        public void Adicionar(Contato contato)
        {
            
            _con.Open();

            var sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", contato.Id, contato.Nome);

            SqlCommand cmd = new SqlCommand(sql, _con);

            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public Contato Obter(Guid id)
        {

            _con.Open();

            var sql = String.Format("SELECT Id, Nome FROM Contato where Id = '{0}';", id);
            

            SqlCommand cmd = new SqlCommand(sql, _con);

            var sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            var contato = new Contato()
            {
                Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                Nome = sqlDataReader["Nome"].ToString(),

            };

            return contato;
            
        }

        public List<Contato> ObterTodos()
        {
            var contatos = new List<Contato>();
            _con.Open();

            var sql = String.Format("SELECT Id, Nome FROM Contato;");


            SqlCommand cmd = new SqlCommand(sql, _con);

            var sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                var contato = new Contato()
                {
                    Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                    Nome = sqlDataReader["Nome"].ToString(),
                };

                contatos.Add(contato);
            }

            return contatos;

        }
    }
}
