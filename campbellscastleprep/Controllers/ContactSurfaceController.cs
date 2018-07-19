using campbellscastleprep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace campbellscastleprep.Controllers
{
    public class ContactSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpPost]
        // GET: ContactSurface
        public ActionResult send(ContactModel contact)
        {
            //Check to see if the submission is valid
            if (!ModelState.IsValid)
            {
                return RedirectToUmbracoPage(contact.UmbracoID);
            }
            return CurrentUmbracoPage();
        }


        private void SendEmail(ContactModel contact)
        {
            MailMessage message = new MailMessage(contact.EmailAddress, "tashanidavidson40@gmail.com");
            message.Subject = string.Format("Enquiry from {0} {1} - {2}", contact.Firstname, contact.Lastname, contact.EmailAddress, contact.TelephoneNumber);
            message.Body = contact.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }

    }

}
























