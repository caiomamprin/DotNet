using System;
using System.Data.SqlClient;


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

        public void Adicionar(string id, string nome)
        {
            
            _con.Open();

            var sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", id, nome);

            SqlCommand cmd = new SqlCommand(sql, _con);

            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public string ObterContato(object id)
        {

            _con.Open();
            var sql = String.Format("SELECT Nome FROM Contato where Id = '{0}';", id);

            SqlCommand cmd = new SqlCommand(sql, _con);

            return  cmd.ExecuteScalar().ToString();
            
        }
    }
}
