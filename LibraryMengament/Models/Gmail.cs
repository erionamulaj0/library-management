using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Threading.Tasks;

namespace LibraryMengament.Models
{
    public class Gmail
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public async Task SendMail(Gmail model)
        {
            using (SmtpClient client = new SmtpClient("email-smtp.eu-west-1.amazonaws.com", 587))
            {
                client.Credentials = new NetworkCredential("AKIAWFX6B57XVOR4TW5M", "BFiH0NKmpMJnb8VQLW46MUtz4FDw88LDdqBvg/OgGHwD");
                client.EnableSsl = true;

                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("zekije_eriona@constack.co");
                    message.To.Add(new MailAddress(model.To));
                    message.Subject = model.Subject;
                    message.Body = model.Body;
                    message.IsBodyHtml = false;
                    await client.SendMailAsync(message);
                }
            }
        }

    }

}