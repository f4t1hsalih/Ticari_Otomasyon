﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmNotes : Form
    {
        public FrmNotes()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void List()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_notes", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_notes(date, hour, title, detail, creator, appeal) values (@p1, @p2, @p3, @p4, @p5)", con.connection());
            cmd.Parameters.AddWithValue("@p1", mskDate.Text);
            cmd.Parameters.AddWithValue("@p2", mskHour.Text);
            cmd.Parameters.AddWithValue("@p3", txtTitle.Text);
            cmd.Parameters.AddWithValue("@p4", rchDetail.Text);
            cmd.Parameters.AddWithValue("@p5", txtCreator.Text);
            cmd.Parameters.AddWithValue("@p1", txtAppeal.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Not başarıyla kayedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["notes_id"].ToString();
                txtTitle.Text = dr["title"].ToString();
                rchDetail.Text = dr["detail"].ToString();
                txtCreator.Text = dr["creator"].ToString();
                mskDate.Text = dr["date"].ToString();
                mskHour.Text = dr["hour"].ToString();
            }
        }
    }
}
