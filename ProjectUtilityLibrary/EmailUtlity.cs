using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilityLibrary
{
    public class EmailUtlity
    {
        public void SendSMTP()
        {
            using (SmtpClient SmtpServer = new SmtpClient("smtp.live.com"))
            {
                var mail = new MailMessage();
                mail.From = new MailAddress("EMAIL");
                mail.To.Add("emailAddress");
                mail.Subject = "Please activate your account.";
                mail.IsBodyHtml = true;
                string htmlBody;
                htmlBody = "Dear " + "username" + "<br /><br />";
                htmlBody += "Thank you for registering an account.  Please activate your account by visiting the URL below:<br /><br />";
                htmlBody += "Thank you.";
                mail.Body = htmlBody;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("EMAIL", "PASSWORD");
                SmtpServer.EnableSsl = true;
                try
                {
                    SmtpServer.Send(mail);
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
