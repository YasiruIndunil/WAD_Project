using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheGalleryCafe.Controllers
{
    public class MenuController : Controller
    {
        


        // GET: Menu

        public ActionResult MainMenu()
        {
            return View();
        }

        public ActionResult Menu_Partial(string cate)
        {

           // ViewBag.MenuList = 

            return PartialView("Menu_Partial");
        }
    }
}