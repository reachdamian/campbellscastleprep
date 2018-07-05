using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace campbellscastleprep.Models
{
    public class AdmissionModel
    {

        public int AdmissionID { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Parent First Name")]
        public string PFirstname { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Parent Last Name")]
        public string PLastname { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [Display(Name = "What would you like from us?")]
        public string ReasonChoice { get; set; }

        [Display(Name = "Grade Applying for")]
        public string GradeChoice { get; set; }

        
    }
}