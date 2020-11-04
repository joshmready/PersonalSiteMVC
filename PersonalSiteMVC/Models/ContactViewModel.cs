using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //This provides the access to the model validation, allowing for server-side validation on the class in the application

namespace PersonalSiteMVC.Models
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Message Title")]
        public string MessageTitle { get; set; }
        [Required]
        [Display(Name = "Message Body")]
        public string MessageBody { get; set; }
    }
}