using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmCutomers : Form
    {
        public FrmCutomers()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_customers", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmCutomers_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
