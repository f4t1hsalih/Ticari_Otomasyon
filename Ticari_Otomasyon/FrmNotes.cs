using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmNotes : Form
    {
        public FrmNotes()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_notes", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
