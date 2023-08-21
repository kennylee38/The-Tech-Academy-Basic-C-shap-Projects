using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newsletter.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=KENNYL-PC\SQLEXPRESS01;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {


                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@firstName, @lastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    objuct - p = command.ExecuteNonQuery();
                    connection.Close();
                }


                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from Signups";
            List<NewsletterSighUp> singups = new List<NewsletterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDateAdapter reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNuber"].ToString();
                    singups.Add(signup);
                }
            }
            var signupVm = new List<SignupVm>();
            foreach (var signup in signups)
            {
                var signupVms = new SignupVm ();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;
                signupVms.Add(signupVm);

            }

                return View(signupVm);
        }
    }
}

    