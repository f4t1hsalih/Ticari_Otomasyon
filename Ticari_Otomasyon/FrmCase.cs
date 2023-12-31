using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmCase : Form
    {
        public FrmCase()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void ListCustMovements()
        {
            string command = "exec CustMovements";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ListCompMovements()
        {
            string command = "execute CompMovements";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        private void FrmCase_Load(object sender, EventArgs e)
        {
            ListCustMovements();
            ListCompMovements();

            // toplam tututarı bulma
            SqlCommand cmd = new SqlCommand("select sum(total) from tbl_invoice_detail", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblTotal.Text = dr[0].ToString() + " ₺";
            }
            dr.Close();
            con.connection().Close();

            //son ayın faturaları
            SqlCommand cmd2 = new SqlCommand("select top 1 (electric+water+natural_gas+internet+ekstra) as 'Giderler' from tbl_expenses order by expense_id desc", con.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblPayments.Text = dr2[0].ToString() + " ₺";
            }
            dr2.Close();
            con.connection().Close();

            //son ayın personel maaşları
            SqlCommand cmd3 = new SqlCommand("select salaries from tbl_expenses order by expense_id desc", con.connection());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                lblStaffSalaries.Text = dr3[0].ToString() + " ₺";
            }
            dr3.Close();
            con.connection().Close();

            //toplam müşteri sayısı
            SqlCommand cmd4 = new SqlCommand("select count(*) from tbl_customers", con.connection());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                lblCustomerNumber.Text = dr4[0].ToString();
            }
            dr4.Close();
            con.connection().Close();

            //toplam firma sayısı
            SqlCommand cmd5 = new SqlCommand("select count(*) from tbl_companies", con.connection());
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                lblCompanyNumber.Text = dr5[0].ToString();
            }
            dr5.Close();
            con.connection().Close();

            //firma şehir sayısı
            SqlCommand cmd6 = new SqlCommand("select count(distinct(province)) from tbl_companies", con.connection());
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                lblProvinceNumber.Text = dr6[0].ToString();
            }
            dr6.Close();
            con.connection().Close();

            //personel sayısı
            SqlCommand cmd7 = new SqlCommand("select count(*) from tbl_staff", con.connection());
            SqlDataReader dr7 = cmd7.ExecuteReader();
            if (dr7.Read())
            {
                lblStaffNumber.Text = dr7[0].ToString();
            }
            dr7.Close();
            con.connection().Close();

            //stok sayısı
            SqlCommand cmd8 = new SqlCommand("select sum(piece) from tbl_products", con.connection());
            SqlDataReader dr8 = cmd8.ExecuteReader();
            if (dr8.Read())
            {
                lblStockNumber.Text = dr8[0].ToString();
            }
            dr8.Close();
            con.connection().Close();
        }
    }
}
