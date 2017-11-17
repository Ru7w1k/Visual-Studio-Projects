using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServerWithAspNetIdentity.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            MailMessage mailMessage = new MailMessage("timerservice123@gmail.com", email, subject, message);
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.SubjectEncoding = Encoding.UTF8;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("timerservice123@gmail.com", "nilesh123");

            //ServicePointManager.SecurityProtocol =
            //    SecurityProtocolType.Ssl3
            //    | SecurityProtocolType.Tls12
            //    | SecurityProtocolType.Tls11
            //    | SecurityProtocolType.Tls;

            smtpClient.Send(mailMessage);

            return Task.CompletedTask;
        }
    }
}
