using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_invoice_info", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Clean()
        {
            txtID.Clear();
            txtSerie.Clear();
            txtSequenceNumber.Clear();
            mskDate.Clear();
            mskHour.Clear();
            txtTaxAdministration.Clear();
            txtBuyer.Clear();
            txtDeliverer.Clear();
            txtReceiver.Clear();
            txtProdName.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtInvoiceProdID.Clear();
        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInvoiceProdID.Text == "")
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_invoice_info (serie, sequence_number, date, hour, tax_administration, buyer, deliverer, receiver) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtSerie.Text);
                cmd.Parameters.AddWithValue("@p2", txtSequenceNumber.Text);
                cmd.Parameters.AddWithValue("@p3", mskDate.Text);
                cmd.Parameters.AddWithValue("@p4", mskHour.Text);
                cmd.Parameters.AddWithValue("@p5", txtTaxAdministration.Text);
                cmd.Parameters.AddWithValue("@p6", txtBuyer.Text);
                cmd.Parameters.AddWithValue("@p7", txtDeliverer.Text);
                cmd.Parameters.AddWithValue("@p8", txtReceiver.Text);
                cmd.ExecuteNonQuery();
                con.connection().Close();
                MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
                Clean();
            }

            //Firma Carisi
            if (txtInvoiceProdID.Text != "" && cmbType.Text == "Firma")
            {
                double amount, price, total;
                price = Convert.ToDouble(txtPrice.Text);
                amount = Convert.ToDouble(txtAmount.Text);
                total = amount * price;
                txtTotal.Text = total.ToString();

                SqlCommand cmd = new SqlCommand("insert into tbl_invoice_detail (prod_name, amount, price, total, invoice_info_id) values (@p1, @p2, @p3, @p4, @p5)", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtProdName.Text);
                cmd.Parameters.AddWithValue("@p2", txtAmount.Text);
                cmd.Parameters.AddWithValue("@p3", txtPrice.Text);
                cmd.Parameters.AddWithValue("@p4", txtTotal.Text);
                cmd.Parameters.AddWithValue("@p5", txtInvoiceProdID.Text);
                cmd.ExecuteNonQuery();
                con.connection().Close();

                //Hareket tablosuna veri kaydetme
                SqlCommand cmd2 = new SqlCommand("insert into tbl_compMovements (prod_id, piece, staff_id, comp_id, price, total, invoice_info_id, date) values (@h1, @h2, @h3, @h4, @h5, @h6, @h7, @h8)", con.connection());
                cmd2.Parameters.AddWithValue("@h1", txtProdID.Text);
                cmd2.Parameters.AddWithValue("@h2", txtAmount.Text);
                cmd2.Parameters.AddWithValue("@h3", txtStaffID.Text);
                cmd2.Parameters.AddWithValue("@h4", txtCompID.Text);
                cmd2.Parameters.AddWithValue("@h5", decimal.Parse(txtPrice.Text));
                cmd2.Parameters.AddWithValue("@h6", decimal.Parse(txtTotal.Text));
                cmd2.Parameters.AddWithValue("@h7", txtInvoiceProdID.Text);
                cmd2.Parameters.AddWithValue("@h8", mskDate.Text);
                cmd2.ExecuteNonQuery();
                con.connection().Close();

                //Stok Sayısını Azaltma
                SqlCommand cmd3 = new SqlCommand("update tbl_products set piece=piece-@s1 where prod_id=@s2", con.connection());
                cmd3.Parameters.AddWithValue("@s1", txtAmount.Text);
                cmd3.Parameters.AddWithValue("@s2", txtProdID.Text);
                cmd3.ExecuteNonQuery();
                con.connection().Close();

                MessageBox.Show("Faturaya Ait Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
                Clean();
            }

            //Müşteri Carisi
            else if (txtInvoiceProdID.Text != "" && cmbType.Text == "Müşteri")
            {
                double amount, price, total;
                price = Convert.ToDouble(txtPrice.Text);
                amount = Convert.ToDouble(txtAmount.Text);
                total = amount * price;
                txtTotal.Text = total.ToString();

                SqlCommand cmd = new SqlCommand("insert into tbl_invoice_detail (prod_name, amount, price, total, invoice_info_id) values (@p1, @p2, @p3, @p4, @p5)", con.connection());
                cmd.Parameters.AddWithValue("@p1", txtProdName.Text);
                cmd.Parameters.AddWithValue("@p2", txtAmount.Text);
                cmd.Parameters.AddWithValue("@p3", txtPrice.Text);
                cmd.Parameters.AddWithValue("@p4", txtTotal.Text);
                cmd.Parameters.AddWithValue("@p5", txtInvoiceProdID.Text);
                cmd.ExecuteNonQuery();
                con.connection().Close();

                //Hareket tablosuna veri kaydetme
                SqlCommand cmd2 = new SqlCommand("insert into tbl_custMovements (prod_id, piece, staff_id, cust_id, price, total, invoice_info_id, date) values (@h1, @h2, @h3, @h4, @h5, @h6, @h7, @h8)", con.connection());
                cmd2.Parameters.AddWithValue("@h1", txtProdID.Text);
                cmd2.Parameters.AddWithValue("@h2", txtAmount.Text);
                cmd2.Parameters.AddWithValue("@h3", txtStaffID.Text);
                cmd2.Parameters.AddWithValue("@h4", txtCompID.Text);
                cmd2.Parameters.AddWithValue("@h5", decimal.Parse(txtPrice.Text));
                cmd2.Parameters.AddWithValue("@h6", decimal.Parse(txtTotal.Text));
                cmd2.Parameters.AddWithValue("@h7", txtInvoiceProdID.Text);
                cmd2.Parameters.AddWithValue("@h8", mskDate.Text);
                cmd2.ExecuteNonQuery();
                con.connection().Close();

                //Stok Sayısını Azaltma
                SqlCommand cmd3 = new SqlCommand("update tbl_products set piece=piece-@s1 where prod_id=@s2", con.connection());
                cmd3.Parameters.AddWithValue("@s1", txtAmount.Text);
                cmd3.Parameters.AddWithValue("@s2", txtProdID.Text);
                cmd3.ExecuteNonQuery();
                con.connection().Close();

                MessageBox.Show("Faturaya Ait Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
                Clean();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["invoice_info_id"].ToString();
                txtSerie.Text = dr["serie"].ToString();
                txtSequenceNumber.Text = dr["sequence_number"].ToString();
                mskDate.Text = dr["date"].ToString();
                mskHour.Text = dr["hour"].ToString();
                txtTaxAdministration.Text = dr["tax_administration"].ToString();
                txtBuyer.Text = dr["buyer"].ToString();
                txtDeliverer.Text = dr["deliverer"].ToString();
                txtReceiver.Text = dr["receiver"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string command = "delete from tbl_invoice_info where invoice_info_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string command = "update tbl_invoice_info set serie = @p1, sequence_number = @p2, date = @p3, hour = @p4, tax_administration = @p5, buyer = @p6, deliverer = @p7, receiver = @p8 where invoice_info_id = @p9";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtSerie.Text);
            cmd.Parameters.AddWithValue("@p2", txtSequenceNumber.Text);
            cmd.Parameters.AddWithValue("@p3", mskDate.Text);
            cmd.Parameters.AddWithValue("@p4", mskHour.Text);
            cmd.Parameters.AddWithValue("@p5", txtTaxAdministration.Text);
            cmd.Parameters.AddWithValue("@p6", txtBuyer.Text);
            cmd.Parameters.AddWithValue("@p7", txtDeliverer.Text);
            cmd.Parameters.AddWithValue("@p8", txtReceiver.Text);
            cmd.Parameters.AddWithValue("@p9", txtID.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmInvoiceProducts invoiceProduct = new FrmInvoiceProducts();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                invoiceProduct.id = dr["invoice_info_id"].ToString();
            }
            invoiceProduct.Show();
        }
    }
}
