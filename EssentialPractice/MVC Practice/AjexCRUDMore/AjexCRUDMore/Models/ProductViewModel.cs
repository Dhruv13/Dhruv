using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjexCRUDMore.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
    }
}