using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TheGalleryCafe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
       
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Logout()
        {
            // Sign out the user
            FormsAuthentication.SignOut();

            // Clear the authentication cookie (if using cookie authentication)
            Session.Clear();
            Session.Abandon();

            // Redirect to the home page or login page
            return RedirectToAction("Index", "Home"); // Or RedirectToAction("Login", "Account");
        }

    }
}