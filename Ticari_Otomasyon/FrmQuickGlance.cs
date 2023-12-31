using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmQuickGlance : Form
    {
        public FrmQuickGlance()
        {
            InitializeComponent();
        }

        SqlConn con = new SqlConn();

        void Stocks()
        {
            SqlDataAdapter da = new SqlDataAdapter("select name as 'Ürün Adı', sum(piece) as 'Stok Adeti' from tbl_products group by name having sum(piece)<=20 order by sum(piece)", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlStocks.DataSource = dt;
        }

        void Agenda()
        {
            SqlDataAdapter da = new SqlDataAdapter("select date as 'Tarih', hour as 'Saat', title as 'Başlık', detail 'Detay', creator as 'Oluşturan', appeal as 'Hitap' from tbl_notes", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlAgenda.DataSource = dt;
        }

        void CompMovements()
        {
            SqlDataAdapter da = new SqlDataAdapter("exec CompMovements2", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlCompMovements.DataSource = dt;
        }

        void Fihrist()
        {
            SqlDataAdapter da = new SqlDataAdapter("select name as 'Firma Adı', tel1 as 'Telefon' from tbl_companies", con.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlFihrist.DataSource = dt;
        }

        private void FrmQuickGlance_Load(object sender, EventArgs e)
        {
            Stocks();
            Agenda();
            CompMovements();
            Fihrist();

            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
