using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
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
            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            var pwd = @"ZrVTQioZwza1kqHWrpSesbHk8YmuxVoEEv5hT/Fp1MDEjMK6BuL9Hr6E+VzmqR3pfcvcTfJLl9DI1qAhAxRYpy6u3AXNHqiJ2eXXkwep01HWvmxbDh3ifD6Kd6GiVCWasisXorMDZuX4i1V17WR+ZpPBQhyA5z73iOOoS6FK4J8=";
           
            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(new RSAParameters
            {
                Modulus = Convert.FromBase64String(@"z09m/ssyAnat8e/Obe9tSTuzoz/8Ok6uwxQp+TuvWA/joRRsI4YkLQbdsj7bEawqjgN1Ag2GLttiYN1rZ4VHO1NdUbXTCfDh43u6B9K2LtvGT56XP/4twIrR4UgmNgNdeomDR8HFv1eHDKiUAm7VlegBvbdlQqh2kDxZ7oPVfck="),
                Exponent = Convert.FromBase64String(@"AQAB"),
                P = Convert.FromBase64String(@"1UUxF/zon+k3SW5Yd1z1th64faseFU7z+bZ5OMIUZytItH0gR+ogMleTYZU7OzLelDRDoxRLgIs9kX0TOp1mww=="),
                Q = Convert.FromBase64String(@"+NiC56nzzDEcF6mpfsxpNY+mAXc8ca/oNlDmNxWZn5Ke5DEnJ+NsULQsiZCl3BcmV54tRw7MJ1AKjUr3xX/4gw=="),
                DP = Convert.FromBase64String(@"OPBNKCNck/z2xsMQGWYXL7VJ+jsqP/QhTQT7njyqp9S1h4J0kN6gE/Cvp3jpJGfzZswBVtO/SKVkHaiv7pFBcw=="),
                DQ = Convert.FromBase64String(@"Su0+NSzqGIBs+f7+5wv7XcI79NMHIyAZJkmjl9BsKi0GpKTcKlmC4qXthxpDpopd5CHfdjbRZ8Dk/HgnNJN8qw=="),
                InverseQ = Convert.FromBase64String(@"1LsaCyhlunFZ0DN7bz6LeOZMpieOBlrtjAxj15M7qFPmDOr2rEcsU6HZX3wfDkFzxgpiC826z8jkPFu5117u6A=="),
                D = Convert.FromBase64String(@"kf2Qwo3FwgZhqKb/8FtT0ubAMo60yTrvx2FDzchCSvmli6IeJUYp46uaJBQvodpkfW3h0HhFrmnAdgZ3xIcPCWrUyfOoWMXQ46Jdx1Lxtt2VfrBwWcf8tcNaKOZzJ0C3/3qqBXe0GdeYnQoprEFCf++YP7Wsiyv6LmbkfhwcZSE="),
                
            });
            var password = csp.Decrypt(Convert.FromBase64String(pwd), true);

            MailMessage mailMessage = new MailMessage("timerservice123@gmail.com", email, subject, message);
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.SubjectEncoding = Encoding.UTF8;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("timerservice123@gmail.com", ByteConverter.GetString(password));
            
            smtpClient.Send(mailMessage);

            return Task.CompletedTask;
        }
    }
}
