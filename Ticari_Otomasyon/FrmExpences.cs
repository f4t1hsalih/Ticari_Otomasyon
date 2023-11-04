using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmExpences : Form
    {
        public FrmExpences()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void Clean()
        {
            txtID.Clear();
            cmbMonth.Clear();
            cmbYear.Clear();
            txtElectric.Clear();
            txtWater.Clear();
            txtNaturalGas.Clear();
            txtInternet.Clear();
            txtSalaries.Clear();
            txtEkstra.Clear();
            rchNotes.Clear();
        }
        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_expenses", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmExpences_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string command = "insert into tbl_expenses (month, year, electric, water, natural_gas, internet, salaries, ekstra, notes) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", cmbMonth.Text);
            cmd.Parameters.AddWithValue("@p2", cmbYear.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtElectric.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(txtNaturalGas.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtSalaries.Text));
            cmd.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            cmd.Parameters.AddWithValue("@p9", rchNotes.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Gider Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["expense_id"].ToString();
                cmbMonth.Text = dr["month"].ToString();
                cmbYear.Text = dr["year"].ToString();
                txtElectric.Text = dr["electric"].ToString();
                txtWater.Text = dr["water"].ToString();
                txtNaturalGas.Text = dr["natural_gas"].ToString();
                txtInternet.Text = dr["internet"].ToString();
                txtSalaries.Text = dr["salaries"].ToString();
                txtEkstra.Text = dr["ekstra"].ToString();
                rchNotes.Text = dr["notes"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string command = "delete from tbl_expenses where expense_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string command = "update tbl_expenses set month = @p1, year = @p2, electric = @p3, water = @p4, natural_gas = @p5, internet = @p6, salaries = @p7, ekstra = @p8, notes = @p9 where expense_id = @p10";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", cmbMonth.Text);
            cmd.Parameters.AddWithValue("@p2", cmbYear.Text);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtElectric.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(txtNaturalGas.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtSalaries.Text));
            cmd.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            cmd.Parameters.AddWithValue("@p9", rchNotes.Text);
            cmd.Parameters.AddWithValue("@p10", txtID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Gider Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();
        }
    }
}
