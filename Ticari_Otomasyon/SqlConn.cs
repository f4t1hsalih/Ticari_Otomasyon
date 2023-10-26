using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class SqlConn
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = DB_TicariOtomasyon; Integrated Security = True");
            connect.Open();
            return connect;
        }
    }
}
