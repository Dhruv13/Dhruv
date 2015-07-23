using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjexCRUD.Models
{
    public class CategoryModel
    {
      
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
    }
}