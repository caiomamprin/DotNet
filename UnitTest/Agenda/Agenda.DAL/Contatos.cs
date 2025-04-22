using System;
using System.Data.SqlClient;


namespace Agenda.DAL
{
    public class Contatos
    {
        public void Adicionar(string id, string nome)
        {
            string strConnection = @"Data Source =.\sqlexpress;Initial Catalog=Agenda;Integrated Security=True;";

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();

            string sql = String.Format("insert into Contato (Id,Nome) values ('{0}', '{1}');", id, nome);

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string ObterContato(object id)
        {
            string strConnection = @"Data Source =.\sqlexpress;Initial Catalog=Agenda;Integrated Security=True;";

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            string sql = String.Format("SELECT Nome FROM Contato where Id = '{0}';", id);

            SqlCommand cmd = new SqlCommand(sql, con);

            return  cmd.ExecuteScalar().ToString();
        }
    }
}
