using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace WebShop.Helpers
{
    public class MailHelper
    {
        public void sendMail(string toEmailAddress, string subject,string content)
        {
            var fromEmailAddress = "datawarehousegroup11chieu@gmail.com";
            var fromEmailDisplayName = "shoponlinemobile";
            var fromEmailPassword = "123456warehouse";
            var smtpHost = "smtp.gmail.com";
            var smtpPort = 587;
            //bool enabledSsl = true;

            string body = content;
            MailMessage message = new MailMessage(new MailAddress(fromEmailAddress, fromEmailDisplayName), new MailAddress(toEmailAddress));

            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = body;

            var client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            client.Host = smtpHost;
            client.EnableSsl = true;
            client.Port = smtpPort;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.Timeout = 3000;
            client.Send(message);
        }
    }
}
