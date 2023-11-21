using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmInvoiceProducts : Form
    {
        public FrmInvoiceProducts()
        {
            InitializeComponent();
        }

        public string id;
        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_invoice_detail where invoice_info_id='" + id + "'", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmInvoiceProducts_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
