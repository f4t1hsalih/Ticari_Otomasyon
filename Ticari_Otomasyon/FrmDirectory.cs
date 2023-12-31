﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void CustomersList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name, surname, tel1, tel2, mail from tbl_customers", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void CompaniesList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name, authorized_name_surname, tel1, tel2, tel3, mail, fax from tbl_companies", con.connection());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            CustomersList();
            CompaniesList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail mail = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                mail.mail = dr["mail"].ToString();
            }

            mail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail mail = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                mail.mail = dr["mail"].ToString();
            }

            mail.Show();
        }
    }
}
