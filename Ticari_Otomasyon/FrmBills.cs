﻿using System;
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

        private void FrmBills_Load(object sender, EventArgs e)
        {
            List();
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
                MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List();
            }
        }
    }
}
