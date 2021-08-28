using System;
using System.Threading.Tasks;

namespace EmailSender
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string toEmail = " which email you want to send email ";
            string subject = "email title";
            string content = "email content";
            SmtpSender smtpSender = new SmtpSender();
            await smtpSender.SendEmailAsync(toEmail,subject,content);

            Console.WriteLine("Email has been sent successfully");

        }
    }
}
