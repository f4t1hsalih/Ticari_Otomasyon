using System;
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

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_companies", con.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            List();
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
                txtCode1.Text = dr["special_code2"].ToString();
                txtCode3.Text = dr["special_code3"].ToString();
            }
        }
    }
}
