using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_products", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        private void FrmProducts_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Verileri Kaydetme
            string command = "insert into tbl_products (name, brand, model, year, piece, bprice, sprice, detail) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtBrand.Text);
            cmd.Parameters.AddWithValue("@p3", txtModel.Text);
            cmd.Parameters.AddWithValue("@p4", mskYear.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse(nudPiece.Text));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txtBPrice.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txtSPrice.Text));
            cmd.Parameters.AddWithValue("@p8", rtbDetail.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Verileri Silme
            string command = "delete from tbl_products where prod_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }
    }
}
