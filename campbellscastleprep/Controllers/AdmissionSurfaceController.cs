using campbellscastleprep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace campbellscastleprep.Controllers
{
    public class AdmissionSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpPost]
        // GET: AdmissionSurface
        public ActionResult submit(AdmissionModel admission)
        {
       
            if (!ModelState.IsValid)
            {
                return RedirectToUmbracoPage(admission.AdmissionID);
            }
            return CurrentUmbracoPage();
        }
       

        private void SendEmail(AdmissionModel admission)
        {
            MailMessage message = new MailMessage(admission.EmailAddress, "cjc@centralja.com");
            message.Subject = string.Format("Enquiry from {0} {1} - {2}", admission.Firstname, admission.Lastname, admission.EmailAddress,
                                           admission.TelephoneNumber, admission.HomeAddress, admission.GradeChoice, admission.PFirstname, 
                                           admission.PLastname, admission.ReasonChoice);
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }

       

    }

}