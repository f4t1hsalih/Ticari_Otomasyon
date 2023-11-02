using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void CustomersList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name, surname, tel1, tel2, mail from tbl_customers", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            CustomersList();
        }
    }
}
