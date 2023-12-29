using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_admin", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            List();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text=="KAYDET")
            {
            SqlCommand cmd = new SqlCommand("insert into tbl_admin values (@p1, @p2)", con.connection());
            cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Yeni Admin Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            }
            if (simpleButton1.Text=="GÜNCELLE")
            {
                SqlCommand cmd = new SqlCommand("upate tbl_admin set password = @p2 where username = @p1", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                cmd.ExecuteNonQuery();
                con.connection().Close();
                MessageBox.Show("Admin Şifresi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                List();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtUsername.Text = dr["username"].ToString();
                txtPassword.Text = dr["password"].ToString();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text!=null)
            {
                simpleButton1.Text = "GÜNCELLE";
            }
            else
            {
                simpleButton1.Text = "KAYDET";
            }
        }
    }
}
