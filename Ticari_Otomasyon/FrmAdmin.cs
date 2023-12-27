using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        private void btnEntry_MouseHover(object sender, EventArgs e)
        {
            btnEntry.BackColor = Color.LightGreen;
        }

        private void btnEntry_MouseLeave(object sender, EventArgs e)
        {
            btnEntry.BackColor = Color.LightCyan;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_admin where username = @p1 and password = @p2", con.connection());
            cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Hatalı", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.connection().Close();
        }
    }
}
