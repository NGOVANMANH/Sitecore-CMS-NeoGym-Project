using Sitecore.Configuration;

public class EmailConfig
{
    public string SmtpServer => Settings.GetSetting("SmtpServer", "default-smtp-server.com");
    public int SmtpPort => int.TryParse(Settings.GetSetting("SmtpPort", "25"), out int port) ? port : 25;
    public string SmtpUsername => Settings.GetSetting("SmtpUsername", "");
    public string SmtpPassword => Settings.GetSetting("SmtpPassword", "");
    public bool EnableSsl => Settings.GetBoolSetting("EnableSsl", true);
    public string EmailSender => Settings.GetSetting("EmailSender", "no-reply@yourdomain.com");
}