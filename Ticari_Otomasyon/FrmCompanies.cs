using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmCompanies : Form
    {
        public FrmCompanies()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_companies", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
