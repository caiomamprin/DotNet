using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Signa.Library.Helpers;

namespace Signa.Default.Template1.Data.Repository
{
    public abstract class RepositoryBase
    {
        public const string _n = "\n";
        public static int _usuarioId;
        public static int _empresaId;


        public static IDbConnection Connection
        {
            get
            {
                var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString + "Api:" + Global.NomeApi + " U:" + _usuarioId);
                conn.Open();
                conn.Execute("Set Transaction Isolation Level Read UnCommitted");
                return conn;
            }
        }

        public RepositoryBase()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
    }
}