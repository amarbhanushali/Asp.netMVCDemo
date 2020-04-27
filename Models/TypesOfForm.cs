using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CashBack.Models
{
    public class TypesOfForm
    {
        public int Id { get; set; }

        [Display(Name = "Types")]
        [Required]
        public string type { get; set; }
    }
}