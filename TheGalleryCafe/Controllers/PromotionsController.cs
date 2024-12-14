using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Class;

namespace TheGalleryCafe.Controllers
{
    public class PromotionsController : Controller
    {
        // GET: Promotions
        public ActionResult PromotionsList()
        {

            return PartialView("PromotionsList");
        }
    }
}