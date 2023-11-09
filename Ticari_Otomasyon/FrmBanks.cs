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
            //Prosedür ile  sql kodu çalıştırma
            string command = "execute Bank_Info";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
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
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            List();
            ProvinceList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string command = "insert into tbl_banks (name, province, district, branch, iban, account_number, authorized, tel, date, account_type, comp_id) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtBankName.Text);
            cmd.Parameters.AddWithValue("@p2", cmbProvince.Text);
            cmd.Parameters.AddWithValue("@p3", cmbDistrict.Text);
            cmd.Parameters.AddWithValue("@p4", txtBranch.Text);
            cmd.Parameters.AddWithValue("@p5", mskIBAN.Text);
            cmd.Parameters.AddWithValue("@p6", txtAccount_Number.Text);
            cmd.Parameters.AddWithValue("@p7", txtAuthorized.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel.Text);
            cmd.Parameters.AddWithValue("@p9", mskDate.Text);
            cmd.Parameters.AddWithValue("@p10", txtAccount_Type.Text);
            cmd.Parameters.AddWithValue("@p11", int.Parse(txtCompanie.Text));
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Banka Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            //Clean();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistrictList();
        }
    }
}
