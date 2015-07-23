using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuThentication.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string UserMail { get; set; }
        [Required]
        [MinLength(5),MaxLength(15)]
        public string UserPass { get; set; }
        [Required]
        [Compare("UserPass")]
        public string ReenterPass { get; set; }


    }
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserMail { get; set; }
        [Required]
        public string UserPass { get; set; }
        public bool RememberMe { get; set; }
    }
}