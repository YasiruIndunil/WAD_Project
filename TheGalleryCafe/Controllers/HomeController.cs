using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TheGalleryCafe.Class;

namespace TheGalleryCafe.Controllers
{
    public class HomeController : Controller
    {

        ClsMealItem _MealItem = new ClsMealItem();


        public ActionResult Index()
        {
            ViewBag.MealTypeList = _MealItem.GetMealTypeList();


            return View();
        }
             public ActionResult AdminPortal()
             {
  

                return View();
            }

        public ActionResult Menu_Partial(string MealItemID)
        {
            ViewBag.MenuList = _MealItem.GetMenu(MealItemID);

            return PartialView("Menu_Partial");


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