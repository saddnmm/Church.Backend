using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Church.Email
{
    public static class EmailController
    {
        public static async Task SendEmailAsync()
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.UseDefaultCredentials = true;
            smtpClient.EnableSsl = true;


            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("spasskysobor.ru@mail.ru", "spasskysobor");
            // кому отправляем
            MailAddress to = new MailAddress("fox.334@mail.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 465);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("spasskysobor.ru@mail.ru", "wNZpsNi,^rQ(5[w");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }        
    }
}
