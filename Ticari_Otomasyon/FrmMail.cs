using System;
using System.Net.Mail;
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
            txtmail.Text = mail;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Mail", "Şifre");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            message.To.Add(rchMessageBody.Text);
            message.From = new MailAddress("Mail");
            message.Subject = txTitle.Text;
            message.Body = rchMessageBody.Text;
            istemci.Send(message);
        }
    }
}
