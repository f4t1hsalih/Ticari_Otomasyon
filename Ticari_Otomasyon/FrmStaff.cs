using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmStaff : Form
    {
        public FrmStaff()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void Clean()
        {
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            mskTel.Clear();
            mskTC.Clear();
            txtMail.Clear();
            cmbProvince.Clear();
            cmbDistrict.Clear();
            rchAddress.Clear();
            txtDuty.Clear();
        }
        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_staff", con.connection());
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

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            List();
            Clean();
            ProvinceList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDistrict.Text = "";
            DistrictList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string command = "insert into tbl_staff (name, surname, tel, tc, mail, province, district, address, duty) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", mskTel.Text);
            cmd.Parameters.AddWithValue("@p4", mskTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtMail.Text);
            cmd.Parameters.AddWithValue("@p6", cmbProvince.Text);
            cmd.Parameters.AddWithValue("@p7", cmbDistrict.Text);
            cmd.Parameters.AddWithValue("@p8", rchAddress.Text);
            cmd.Parameters.AddWithValue("@p9", txtDuty.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["staff_id"].ToString();
                txtName.Text = dr["name"].ToString();
                txtSurname.Text = dr["surname"].ToString();
                mskTel.Text = dr["tel"].ToString();
                mskTC.Text = dr["tc"].ToString();
                txtMail.Text = dr["mail"].ToString();
                cmbProvince.Text = dr["province"].ToString();
                cmbDistrict.Text = dr["district"].ToString();
                rchAddress.Text = dr["address"].ToString();
                txtDuty.Text = dr["duty"].ToString();
            }
        }
    }
}
