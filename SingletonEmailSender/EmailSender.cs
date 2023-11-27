using System.Net;
using System.Net.Mail;


namespace SingletonEmailSender;

public class EmailSender:IEmailSender
{
    private static readonly EmailSender Instance = new EmailSender();
    
    public static EmailSender GetInstance() => Instance;
    
    public async Task SendAsync(MailInfo mail)
    {
        var message = CreateEmailMessage(mail);
        await SendMessageAsync(message);
    }
    
    /// <summary>
    /// Form message
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    MailMessage CreateEmailMessage(MailInfo data)
    {
        MailMessage message = new MailMessage(data.EmailFrom, data.EmailTo);

        message.Subject = data.Subject ?? "";

        message.Body = data.Message ?? "";
        
        return message;
    }
    
    /// <summary>
    /// Отправляет сообщение асинхронно
    /// </summary>
    /// <param name="mailMessage"></param>
    /// <returns></returns>
    async Task SendMessageAsync(MailMessage mailMessage)
    {
        var client = new SmtpClient("smtp.mail.ru", 587);
        
        try
        {
            client.Credentials = new NetworkCredential("anatolypanushkin@mail.ru", "z3ubucGK7zw8UZrdpR1y");
            client.EnableSsl = true;
            client.Send(mailMessage);
        }
        catch
        {
            throw new Exception("Error sending Email");
        }
    }

}