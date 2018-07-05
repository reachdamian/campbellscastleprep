using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace campbellscastleprep.Models
{
    public class ContactModel
    {
        public int UmbracoID { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display (Name ="First Name")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        [Required]
        
        public string Message { get; set; }
    }
}