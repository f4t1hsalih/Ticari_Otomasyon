﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmCompanies : Form
    {
        public FrmCompanies()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void Clean()
        {
            txtID.Clear();
            txtName.Clear();
            txtAuthorizedStatus.Clear();
            txtAuthorized.Clear();
            txtAuthorizedTc.Clear();
            txtSector.Clear();
            mskTel1.Clear();
            mskTel2.Clear();
            mskTel3.Clear();
            txtMail.Clear();
            mskFax.Clear();
            cmbProvince.Clear();
            cmbDistrict.Clear();
            txtTaxAdministration.Clear();
            rtbAddress.Clear();
            txtCode1.Clear();
            txtCode2.Clear();
            txtCode3.Clear();
        }

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_companies", con.connection());
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

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            List();
            Clean();
            ProvinceList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["comp_id"].ToString();
                txtName.Text = dr["name"].ToString();
                txtAuthorizedStatus.Text = dr["authorized_status"].ToString();
                txtAuthorized.Text = dr["authorized_name_surname"].ToString();
                txtAuthorizedTc.Text = dr["authorized_tc"].ToString();
                txtSector.Text = dr["sector"].ToString();
                mskTel1.Text = dr["tel1"].ToString();
                mskTel2.Text = dr["tel2"].ToString();
                mskTel3.Text = dr["tel3"].ToString();
                txtMail.Text = dr["mail"].ToString();
                mskFax.Text = dr["fax"].ToString();
                cmbProvince.Text = dr["province"].ToString();
                cmbDistrict.Text = dr["distinct"].ToString();
                txtTaxAdministration.Text = dr["tax_administration"].ToString();
                rtbAddress.Text = dr["address"].ToString();
                txtCode1.Text = dr["special_code1"].ToString();
                txtCode2.Text = dr["special_code2"].ToString();
                txtCode3.Text = dr["special_code3"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string command = "insert into tbl_companies (name, authorized_status, authorized_name_surname, authorized_tc, sector, tel1, tel2, tel3, mail, fax, province, [distinct], tax_administration, address, special_code1, special_code2, special_code3) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)";
            SqlCommand cmd = new SqlCommand(command, con.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtAuthorizedStatus.Text);
            cmd.Parameters.AddWithValue("@p3", txtAuthorized.Text);
            cmd.Parameters.AddWithValue("@p4", txtAuthorizedTc.Text);
            cmd.Parameters.AddWithValue("@p5", txtSector.Text);
            cmd.Parameters.AddWithValue("@p6", mskTel1.Text);
            cmd.Parameters.AddWithValue("@p7", mskTel2.Text);
            cmd.Parameters.AddWithValue("@p8", mskTel3.Text);
            cmd.Parameters.AddWithValue("@p9", txtMail.Text);
            cmd.Parameters.AddWithValue("@p10", mskFax.Text);
            cmd.Parameters.AddWithValue("@p11", cmbProvince.Text);
            cmd.Parameters.AddWithValue("@p12", cmbDistrict.Text);
            cmd.Parameters.AddWithValue("@p13", txtTaxAdministration.Text);
            cmd.Parameters.AddWithValue("@p14", rtbAddress.Text);
            cmd.Parameters.AddWithValue("@p15", txtCode1.Text);
            cmd.Parameters.AddWithValue("@p16", txtCode2.Text);
            cmd.Parameters.AddWithValue("@p17", txtCode3.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Firma Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistrictList();
        }
    }
}
