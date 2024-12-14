using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Class;

namespace TheGalleryCafe.Controllers
{
    public class BookingController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Booking
        [Authorize(Roles = "Booking")]
        public ActionResult BookingPage()
        {
            return View();
        }

        public ActionResult AvailableTablesList()
        {
            var availableTables = db.Tables.Where(t => t.IsAvailable).ToList();
            return PartialView("AvailableTablesList", availableTables);
   
        }



        public ActionResult AvailableTables()
        {
            var tables = db.Tables.Where(t => t.IsAvailable).ToList();
            return View(tables);
        }

        public ActionResult Promotions()
        {
            var promotions = db.Promotions
                               .Where(p => p.StartDate <= System.DateTime.Now && p.EndDate >= System.DateTime.Now)
                               .ToList();
            return View(promotions);
        }

    }
}