using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CashBack.Models
{
    public class TypeOfClaim
    {
        public int Id { get; set; }

        [Display(Name = "Type Of Claim")]
        [Required]
        public string claimType { get; set; }
    }
}