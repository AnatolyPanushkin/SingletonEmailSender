// See https://aka.ms/new-console-template for more informa

using System.Net;
using System.Net.Mail;
using SingletonEmailSender;

IEmailSender _emailSender = new EmailSender();

var mail = new MailInfo()
{
    EmailFrom = "anatolypanushkin@mail.ru",
    EmailTo = "anatolypanushkin@mail.ru",
    Subject = "test"
};

_emailSender.SendAsync(mail);
