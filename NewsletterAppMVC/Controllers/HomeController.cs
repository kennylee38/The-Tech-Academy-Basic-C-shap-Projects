﻿using System;
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

  
        private new ActionResult View(object signupVms)
        {
            throw new NotImplementedException();
        }
    }
}