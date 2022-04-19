using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    abstract class Mail
    {
        protected Customer customer = Customer.CustomerX();
        protected string subject;
        protected string content;
        abstract public void sendMail();

        protected void send(string customerMail, string subject, string content)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(_mail);
            mail.To.Add(customerMail);
            mail.Subject = subject;
            mail.Body = content;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(_mail, _pass);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}