using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmStockDetail : Form
    {
        public FrmStockDetail()
        {
            InitializeComponent();
        }

        public string name;

        SqlConn con = new SqlConn();

        private void FrmStockDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_products where name ='" + name + "'", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
