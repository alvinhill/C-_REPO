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
       private readonly string connectionstring = @"Data Source = EARTH\SQLEXPRESS; Initial Catalog = NewsLetter; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

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
             

                string querystring = @"INSERT INTO Signups (FirstName, LastName,EmailAddress)VALUES (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand(querystring,connection);
                    command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar );
                    command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", System.Data.SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }
       public ActionResult Admin()
        {
            using (NLEntities db = new NLEntities()) {
                var signups = db.SignUps;
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)//EF VIDEO #3 5:36
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;

                    signupVms.Add(signupVm);
                }
                return View(signupVms);





            }

            //string querystring = @"SELECT Id,FirstName,LastName,EmailAddress,SocialSecurityNumber from Signups";

            //List<NEWSSIGNUP> signups = new List<NEWSSIGNUP>();

            //using (SqlConnection connection = new SqlConnection(connectionstring))
            //{
            //    SqlCommand command = new SqlCommand(querystring, connection);

            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())

            //    {
            //        var signup = new NEWSSIGNUP();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

            //        signups.Add(signup);

            //    }

            //}




        }

       

   




    }
}