namespace SingletonEmailSender;

public interface IEmailSender
{
    /// <summary>
    /// Ассинхронно отправляет письмо
    /// </summary>
    /// <param name="mail"></param>
    /// <returns></returns>
    public Task SendAsync(MailInfo mail);
}