using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Class;
using TheGalleryCafe.Models;

namespace TheGalleryCafe.Controllers
{
    public class MenuController : Controller
    {
        ClsMealItem _MealItem = new ClsMealItem();

        // GET: Menu
        [Authorize]
            public ActionResult MainMenu()
            {
            ViewBag.MealTypeList = _MealItem.GetMealTypeList();
            ViewBag.CuisinesList = _MealItem.GetAllCuisines();

            return View();
            }

        public ActionResult Menu_Partial(string MealItemID)
        {
            ViewBag.MenuList = _MealItem.GetMenu(MealItemID);

            return PartialView("Menu_Partial");
        }

        public ActionResult Promo_Partial()
        {
            ViewBag.PromoList = _MealItem.GetPromo();

            return PartialView("Promo_Partial");


        } 
        
        public ActionResult Cuisines_Partial(string CItemID)
        {
            ViewBag.CuisinesList = _MealItem.GetCuisin(CItemID);

            return PartialView("Cuisines_Partial");


        }
    }
}