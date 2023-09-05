using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    { 
        private readonly string connectionString = @"Data Source=KENNYL-PC\SQLEXPRESS01;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private object signupVms;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp(string FirstName, string LastName, string EmailAddress)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))

            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities()) 
                    {
                    var signup = new SignUp();
                    signup.FirstName = FirstName;
                    signup.LastName = LastName;
                    signup.EmailAddress = EmailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                    }



                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            using (NewsletterEntities db = new NewsletterEntities()) 
                {
                var signups = db.SignUps;
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups) {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
               
            }
                return View(signupVms);
        }

        private new ActionResult View(object signupVms)
        {
            throw new NotImplementedException();
        }
    }
}