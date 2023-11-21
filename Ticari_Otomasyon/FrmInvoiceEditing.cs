using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            txtInvoiceInfoID.Text = prodId;

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

        }
    }
}
