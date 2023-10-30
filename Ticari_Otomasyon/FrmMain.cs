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

        FrmCutomers customers;
        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers == null)
            {
                customers = new FrmCutomers();
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
    }
}
