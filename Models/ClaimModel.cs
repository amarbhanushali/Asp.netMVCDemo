using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashBack.Models
{
    public class ClaimModel
    {
        public int Id { get; set; }
       
       
        [Required]
        [Display(Name = "Type of Form")]
        public short TypesOfFormId { get; set; }

        [Required]
        [StringLength(255)]
        public string CompanyName { get; set; }

        [Required]
        public DateTime  OrderDate { get; set; }

        [Required]
        public DateTime InstalltionDateType { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        public DateTime? InputeDate { get; set; }

        [Required]
        [Range( 1,30)]
        public int PartnerRefNo { get; set; }

        
        
        [Required]
        [Display(Name = "Type Of Claim")]
        public short TypeOfClaimId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address1 { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Name of Country")]
        public string Country { get; set; }

        
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "You must provide a phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<>()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }



    }
}