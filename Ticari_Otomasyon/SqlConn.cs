using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class SqlConn
    {

        class sqlconnection
        {
            public SqlConnection connection()
            {
                SqlConnection connect = new SqlConnection(@"Data Source = SALIH\SQLEXPRESS; Initial Catalog = Hastane; Integrated Security = True");
                connect.Open();
                return connect;
            }

        }
    }
}
