using DevExpress.PivotGrid.OLAP.Mdx;
using DevExpress.XtraReports;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public string user;

        FrmProducts products;
        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (products == null)
            {
                products = new FrmProducts();
                products.MdiParent = this;
                products.Show();
            }
        }

        FrmCustomers customers;
        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers == null)
            {
                customers = new FrmCustomers();
                customers.MdiParent = this;
                customers.Show();
            }
        }

        FrmCompanies companies;
        private void btnCompanies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companies == null)
            {
                companies = new FrmCompanies();
                companies.MdiParent = this;
                companies.Show();
            }
        }

        FrmStaff staff;
        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (staff == null)
            {
                staff = new FrmStaff();
                staff.MdiParent = this;
                staff.Show();
            }
        }

        FrmDirectory directory;
        private void btnDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (directory == null)
            {
                directory = new FrmDirectory();
                directory.MdiParent = this;
                directory.Show();
            }
        }

        FrmExpences expences;
        private void btnExpenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expences == null)
            {
                expences = new FrmExpences();
                expences.MdiParent = this;
                expences.Show();
            }
        }

        FrmBanks banks;
        private void btnBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banks == null)
            {
                banks = new FrmBanks();
                banks.MdiParent = this;
                banks.Show();
            }
        }

        FrmBills bills;
        private void btnBills_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bills == null)
            {
                bills = new FrmBills();
                bills.MdiParent = this;
                bills.Show();
            }
        }

        FrmNotes notes;
        private void btnNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notes == null)
            {
                notes = new FrmNotes();
                notes.MdiParent = this;
                notes.Show();
            }
        }

        FrmMovements movements;
        private void btnMovements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (movements == null)
            {
                movements = new FrmMovements();
                movements.MdiParent = this;
                movements.Show();
            }
        }

        FrmStocks stocks;

        private void btnStocks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stocks == null)
            {
                stocks = new FrmStocks();
                stocks.MdiParent = this;
                stocks.Show();
            }
        }

        FrmCase till;

        private void btnCase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (till == null)
            {
                till = new FrmCase();
                till.name = user;
                till.MdiParent = this;
                till.Show();
            }
        }

        FrmSettings settings;

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (settings == null)
            {
                settings = new FrmSettings();
                settings.Show();
            }
        }

        FrmReports reports;

        private void btnReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reports == null)
            {
                reports = new FrmReports();
                reports.MdiParent = this;
                reports.Show();
            }
        }

        private void FrmMain_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
