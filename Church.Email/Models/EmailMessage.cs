using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Church.Email.Models
{
    public class EmailMessage
    {
        public List<MailboxAddress> To {  get; set; }

        public string Subject {  get; set; }

        public string Content { get; set; }

        public EmailMessage(IEnumerable<string> to, string subject, string context)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("email", x)));
            Subject = subject;
            Content = context;         
        }
    }
}
