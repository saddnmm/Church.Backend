using Church.Email;
using System.Net.Mail;

// See https://aka.ms/new-console-template for more information

using System.Net.Mail;
using System.Net;

var from = "spasskysobor.ru@mail.ru";
var to = "spasskysobor.ru@mail.ru";
var subject = "Test mail";
var body = "Test body";

var username = "spasskysobor.ru@mail.ru"; // get from Mailtrap
var password = "53YruktdKxupuebA2cJZ"; // get from Mailtrap

var host = "smtp.mail.ru";
var port = 587;

var client = new SmtpClient(host, port)
{
    Credentials = new NetworkCredential(username, password),
    EnableSsl = true
};

client.Send(from, to, subject, body);

Console.WriteLine("Email sent");


