using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmProducts products ;
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
    }
}
