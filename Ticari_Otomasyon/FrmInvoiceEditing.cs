using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmInvoiceEditing : Form
    {
        public FrmInvoiceEditing()
        {
            InitializeComponent();
        }

        public string prodId;

        void Clean()
        {
            txtProdName.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }

        SqlConn con = new SqlConn();

        private void FrmInvoiceEditing_Load(object sender, EventArgs e)
        {
            txtInvoiceProdID.Text = prodId;

            SqlCommand cmd = new SqlCommand("select * from tbl_invoice_detail where invoice_prod_id ='" + prodId + "'", con.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtProdName.Text = dr[1].ToString();
                txtAmount.Text = dr[2].ToString();
                txtPrice.Text = dr[3].ToString();
                txtTotal.Text = dr[4].ToString();
            }
            con.connection().Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double amount, price, total;
            price = Convert.ToDouble(txtPrice.Text);
            amount = Convert.ToDouble(txtAmount.Text);
            total = amount * price;
            txtTotal.Text = total.ToString();

            string command = "update tbl_invoice_detail set prod_name = @p1, amount = @p2, price = @p3, total = @p4 where invoice_prod_id = @p5";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtProdName.Text);
            cmd.Parameters.AddWithValue("@p2", txtAmount.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtPrice.Text));
            cmd.Parameters.AddWithValue("@p4", Convert.ToDecimal(txtTotal.Text));
            cmd.Parameters.AddWithValue("@p5", txtInvoiceProdID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Fatura Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string command = "delete from tbl_invoice_detail where invoice_prod_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtInvoiceProdID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Faturada Bulunan Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }
    }
}
