using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmMain : Form
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
    }
}
