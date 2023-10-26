using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_products", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
