using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CashBack.Models;
using CashBack.ViewModels;

namespace CashBack.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize]
        public ActionResult Index()
        {
            //geting the View model for Adding list to the form
            
            var viewModel = new ClaimsFormViewModel
            {
                TyeOfClaims = _context.TyeOfClaims.ToList(),
                TypesOfForms = _context.TypesOfForms.ToList(),
                ClaimModel = new ClaimModel()
            };
            return View("ClaimForm",viewModel);
        }

        //define the method of form here & validation of token
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Save(ClaimModel claimModel)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ClaimsFormViewModel
                {
                    TyeOfClaims = _context.TyeOfClaims.ToList(),
                    TypesOfForms = _context.TypesOfForms.ToList(),
                    ClaimModel = claimModel
                };
                return View("ClaimForm", viewModel);
            }

            if (claimModel == null)
                return HttpNotFound();
            //Add the data into Context object
            _context.ClaimModels.Add(claimModel);

            // Save the data into the database
            _context.SaveChanges();

            // Return to Home when data save successfully.
            return RedirectToAction("Index");
        }
    }
}