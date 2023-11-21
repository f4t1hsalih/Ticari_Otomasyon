using System;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmInvoiceProducts : Form
    {
        public FrmInvoiceProducts()
        {
            InitializeComponent();
        }

        public string id;
        private void FrmInvoiceProducts_Load(object sender, EventArgs e)
        {
            label1.Text = id;
        }
    }
}
