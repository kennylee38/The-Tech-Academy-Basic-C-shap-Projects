﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModel;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) 
                {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups) 
                    {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

            }
            object signupVM = null;
            return View(signupVM);
        }
    }
    public ActionResult Unsubscribe(int id, object signup)
    {
        using (NewsletterEntities db = new NewsletterEntities()) 
        {
            object[] Id = null;
            var singup = db.SignUps.Find(Id);
            signup.Removed = DateTime.Now;
            db.SaveChanges();
        }
        return ReDirectToAction("Index");
    }
}