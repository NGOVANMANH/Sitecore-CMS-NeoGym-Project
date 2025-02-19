using System;
using System.Net.Mail;
using System.Net;
using MySite.Foundation.Email.Models;
using Sitecore.Diagnostics;

namespace MySite.Foundation.Email.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfig _config = new EmailConfig();

        public bool SendEmail(EmailRequest emailRequest)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_config.EmailSender),
                    Subject = emailRequest.Subject,
                    Body = emailRequest.Body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(emailRequest.To);

                using (var smtp = new SmtpClient(_config.SmtpServer, _config.SmtpPort))
                {
                    smtp.Credentials = new NetworkCredential(_config.SmtpUsername, _config.SmtpPassword);
                    smtp.EnableSsl = _config.EnableSsl;
                    smtp.Send(mailMessage);
                }

                return true;
            }
            catch (SmtpException smtpEx)
            {
                Log.Error($"EmailService: SMTP error while sending email to {emailRequest.To}", smtpEx, this);
                return false;
            }
            catch (Exception ex)
            {
                Log.Error($"EmailService: General error while sending email to {emailRequest.To}", ex, this);
                return false;
            }
        }
    }
}
