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
        void ProvinceList()
        {
            string command = "Select province from tbl_provinces";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProvince.Properties.Items.Add(dr[0]);
            }
            con.connection().Close();
        }
        void DistrictList()
        {

        }

        private void FrmCutomers_Load(object sender, EventArgs e)
        {
            List();
            ProvinceList();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select district from tbl_districts where province = @p1", con.connection());
            cmd.Parameters.AddWithValue("@p1", cmbProvince.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Properties.Items.Add(dr[0]);
            }
        }
    }
}
