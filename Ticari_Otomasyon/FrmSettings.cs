using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Drawing;

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
            SqlCommand cmd = new SqlCommand("insert into tbl_admin values (@p1, @p2)", con.connection());
            cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Yeni Admin Başarıyla Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
