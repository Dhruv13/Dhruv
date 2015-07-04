using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDMORE.Models
{
    public class LoginViewModel
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public bool Gender{get;set;}
        [Required]
        public int CityId { get; set; }
        public string Hobby1{get;set;}
        public string Hobby2{get;set;}
        public string Hobby3{get;set;}
    }
}