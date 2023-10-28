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
            cmbDistrict.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select district from tbl_districts where province = @p1", con.connection());
            cmd.Parameters.AddWithValue("@p1", cmbProvince.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Properties.Items.Add(dr[0]);
            }
        }

        private void FrmCutomers_Load(object sender, EventArgs e)
        {
            List();
            ProvinceList();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistrictList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string command = "insert into tbl_customers (name, surname, tel1, tel2, tc, mail, province, district, address, tax_administration) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p5", mskTC.Text);
            cmd.Parameters.AddWithValue("@p6", txtMail.Text);
            cmd.Parameters.AddWithValue("@p7", cmbProvince.Text);
            cmd.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            cmd.Parameters.AddWithValue("@p9", rtbAddress.Text);
            cmd.Parameters.AddWithValue("@p10", txtTaxAdministration.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Müşteri Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }
    }
}
