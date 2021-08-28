using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace EmailSender
{
    public class SmtpSender
    {
        private string host = "smtp.gmail.com";
        private int port = 587;
        private bool enableSSl = true;
        private string emailAddress = "";
        private string password = "";
        public Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(emailAddress, password),
                EnableSsl = enableSSl
            };
            

            return client.SendMailAsync(new MailMessage(emailAddress, toEmail, subject, content)
            {
                IsBodyHtml = true
            });
        }
    }
}
