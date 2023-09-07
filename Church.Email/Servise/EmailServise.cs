using Church.Email.Models;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using System.Net.Mail;

namespace Church.Email.Servise
{
    public class EmailServise : IEmailServise
    {
        private readonly EmailConfiguration _emailConfiguration;

        public EmailServise(EmailConfiguration emailConfiguration) => 
            _emailConfiguration = emailConfiguration;

        public void SendEmail(EmailMessage emailMessages)
        {
            var emailMessage = CreateEmailMessage(emailMessages);
            Send(emailMessage);
        }

        public MailMessage CreateEmailMessage(EmailMessage emailMessages)
        {
            var emailMessage = new MailMessage();            
            MailAddress from = new MailAddress(_emailConfiguration.From, "TestFromName");
            MailAddress to = new MailAddress(_emailConfiguration.From, "TestToName");
            MailMessage myMail = new System.Net.Mail.MailMessage(from, to);
            MailAddress replyTo = new MailAddress("spasskysobor.ru@mail.ru");
            myMail.ReplyToList.Add(replyTo);
            emailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            emailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            emailMessage.Subject = emailMessages.Subject;
            emailMessage.Body = emailMessages.Content;
            return emailMessage;
        }

        private void Send(MailMessage emailMessages)
        {
            using var client = new SmtpClient(_emailConfiguration.SmtmServer, _emailConfiguration.Port);
            try
            {
                // set smtp-client with basicAuthentication
                client.UseDefaultCredentials = true;
                client.EnableSsl = true;

                System.Net.NetworkCredential basicAuthenticationInfo = new
                    System.Net.NetworkCredential(_emailConfiguration.Username, _emailConfiguration.Password);
                client.Credentials = basicAuthenticationInfo;
                client.Send(emailMessages);
            }
            catch
            {
                throw;
            }
            
        }
    }
}
