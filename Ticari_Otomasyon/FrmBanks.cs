using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            string command = "select * from tbl_banks";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
