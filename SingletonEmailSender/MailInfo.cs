namespace SingletonEmailSender;

public class MailInfo
{
    public string EmailFrom { get; set; }
    public string EmailTo { get; set; }
    public string? Message { get; set; }
    public string? Subject { get; set; }
    public IEnumerable<MailAttachment> Files { get; set; }
}