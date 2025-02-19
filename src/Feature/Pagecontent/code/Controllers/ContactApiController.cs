using System.Linq;
using System.Web.Mvc;
using MySite.Feature.PageContent.Helper;
using MySite.Feature.PageContent.Models;
using MySite.Foundation.Email.Services;

namespace MySite.Feature.PageContent.Controllers
{
    public class ContactApiController : Controller
    {
        private readonly IEmailService _emailService;

        public ContactApiController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        #region Submit Contact Form API Handler
        [HttpPost]
        public ActionResult Submit(ContactFormRequest contactFormRequest)
        {
            if (!ModelState.IsValid)
            {
                return Content(
                   JsonSerializeHelper.Serialize(new
                   {
                       Success = false,
                       Errors = ModelState.Values
                                    .SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage)
                   }),
                    "application/json"
                );
            }

            this.HandleFormSubmission(contactFormRequest);

            return Content(
                JsonSerializeHelper.Serialize(new
                {
                    Success = true,
                    Message = "Form submitted successfully!",
                    Data = contactFormRequest
                }),
                "application/json"
            ); 
        }

        #endregion

        #region Private Region
        private void HandleFormSubmission(ContactFormRequest contactFormRequest)
        {
            _emailService.SendEmail(new Foundation.Email.Models.EmailRequest
            {
                To = contactFormRequest.Email,
                Subject = "Contact Form Submission",
                Body = $"Name: {contactFormRequest.Username}<br/>Email: {contactFormRequest.Email}<br/>Phone Number: {contactFormRequest.PhoneNumber}<br/>Message: {contactFormRequest.Message}"
            });
        }
        #endregion
    }
}