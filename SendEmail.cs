using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace EmailTester
{
    public partial class SendEmail : Form
    {
        String cacheFile = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName + @"\cache.log";
        public SendEmail()
        {
            InitializeComponent();

            try
            {
                //Read data from cache
                StreamReader sr = new StreamReader(cacheFile);
                txtServer.Text= sr.ReadLine();
                chkSecure.Checked= sr.ReadLine().ToLower() == "true";
                txtPort.Text= sr.ReadLine();
                txtName.Text= sr.ReadLine();
                txtUsername.Text= sr.ReadLine();
                txtPassword.Text= sr.ReadLine();
                txtTo.Text= sr.ReadLine();
                txtSubject.Text= sr.ReadLine();
                txtBody.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            btnSendEmail.Enabled = false;

            // Save last data to a text file, for cache purpose
            StreamWriter sw = new StreamWriter(cacheFile);
            sw.Write(txtServer.Text + Environment.NewLine +
                chkSecure.Checked + Environment.NewLine +
                txtPort.Text + Environment.NewLine +
                txtName.Text + Environment.NewLine +
                txtUsername.Text + Environment.NewLine +
                txtPassword.Text + Environment.NewLine +
                txtTo.Text + Environment.NewLine +
                txtSubject.Text + Environment.NewLine +
                txtBody.Text + Environment.NewLine
                );
            sw.Close();

            txtResult.Text = "";
            MailAddress from = new MailAddress(txtUsername.Text, txtName.Text);
            MailAddress to = new MailAddress(txtTo.Text);

            this.txtResult.BeginInvoke(new Action(() =>
            {
                KirimEmail(txtSubject.Text, from, to);
            }));

            btnSendEmail.Enabled = true;
        }

        protected void KirimEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc = null, List<MailAddress> _bcc = null)
        {
            try
            {
                SmtpClient mailClient = new SmtpClient(txtServer.Text);
                mailClient.Port = int.Parse(txtPort.Text);
                mailClient.UseDefaultCredentials = false;
                mailClient.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                mailClient.EnableSsl = chkSecure.Checked;
                mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage msgMail;
                msgMail = new MailMessage();
                msgMail.From = _from;
                msgMail.To.Add(_to);
                if (_cc != null)
                {
                    foreach (MailAddress addr in _cc)
                    {
                        msgMail.CC.Add(addr);
                    }
                }
                if (_bcc != null)
                {
                    foreach (MailAddress addr in _bcc)
                    {
                        msgMail.Bcc.Add(addr);
                    }
                }
                msgMail.Subject = _subject;
                msgMail.Body = txtBody.Text + "." + Environment.NewLine + Environment.NewLine + "// Sent from " + Dns.GetHostName();
                msgMail.IsBodyHtml = true;

                ServicePointManager.ServerCertificateValidationCallback =
                    delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    {
                        return true;
                    };


                mailClient.Send(msgMail);
                msgMail.Dispose();
                txtResult.Text = "Email has been sent!";
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message + Environment.NewLine + Environment.NewLine + ex.InnerException;
            }
        }
    }
}
