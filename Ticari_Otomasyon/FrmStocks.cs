using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select name, sum(piece) as 'Miktar' from tbl_products group by name", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlCommand cmd = new SqlCommand("Select name, sum(piece) as 'Miktar' from tbl_products group by name", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            con.connection().Close();

            SqlCommand cmd2 = new SqlCommand("Select province, count(*) from tbl_companies group by province", con.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            con.connection().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStockDetail stockDetail = new FrmStockDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                stockDetail.name = dr["name"].ToString();
            }
            stockDetail.Show();
        }
    }
}
