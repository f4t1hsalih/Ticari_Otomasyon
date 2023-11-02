using System;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;

        private void FrmMail_Load(object sender, EventArgs e)
        {
            label1.Text = mail;
        }
    }
}
