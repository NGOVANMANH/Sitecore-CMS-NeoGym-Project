using MySite.Foundation.Email.Models;

namespace MySite.Foundation.Email.Services
{
    public interface IEmailService
    {
        bool SendEmail(EmailRequest emailRequest);
    }
}