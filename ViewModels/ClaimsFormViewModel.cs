using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashBack.Models;

namespace CashBack.ViewModels
{
    public class ClaimsFormViewModel
    {
        public IEnumerable<TypeOfClaim> TyeOfClaims { get; set; }
        public IEnumerable<TypesOfForm> TypesOfForms { get; set; }
        public ClaimModel ClaimModel { get; set; }
    }
}