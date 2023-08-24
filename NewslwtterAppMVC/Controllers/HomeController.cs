using NewslwtterAppMVC.Models;
using NewslwtterAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace NewslwtterAppMVC.Controllers
{
    public class HomeController : Controller
    {
       ////private readonly string connectionstring = @"Data Source = EARTH\SQLEXPRESS; Initial Catalog = NewsLetter; Integrated Security = True; Connect Timeout = 30; Encrypt = False; /TrustServerCertificate = False; ApplicationIntent = ReadWrite; //MultiSubnetFailover = False";

        public ActionResult Index()
        {
            return View();
        }[HttpPost]
        public ActionResult Signup(string firstName,string lastName,string emailAddress)
        {
           if(string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName)||string.IsNullOrEmpty(emailAddress))
                {
                return View("~/Views/Shared/Error.cshtml");
            }
           else
            {
             using (NewsLetterEntities db = new NewsLetterEntities()) 
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

               
                return View("Success");
            }
        }
     

       

   




    }
}