using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewslwtterAppMVC.Models;
using NewslwtterAppMVC.ViewModel;

namespace NewslwtterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsLetterEntities db = new NewsLetterEntities()) 
                
                
                
                {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();// FIND NULLS
                var signupVms = new List<SignupVm>(); // CREATE LIST
                foreach (var signup in signups) 
                    {
                    SignupVm signupVm = new SignupVm();

                    signupVm.FirstName = signup.FirstName; // LOOP THROUGH MODELS AND MAP TO A VIEW MODEL
                    signupVm.Id = signup.Id;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;

                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }

        }
        public ActionResult Unsubscribe(int Id)

        {
            using(NewsLetterEntities db = new NewsLetterEntities()) // CREATES A CONNECTION TO DB
           {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();

            }
            return RedirectToAction("Index");

        }


    }
}