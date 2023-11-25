using System;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmNoteDetail : Form
    {
        public FrmNoteDetail()
        {
            InitializeComponent();
        }

        public string detail;
        private void FrmNoteDetail_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = detail;
        }
    }
}
