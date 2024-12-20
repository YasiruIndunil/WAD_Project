using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Class;
using TheGalleryCafe.Models;

namespace TheGalleryCafe.Controllers
{
    public class ReservationsController : Controller
    {

        ClsReservation _res = new ClsReservation();


        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Reservation model)
        {

            _res.TableReservation(model);

            if (ModelState.IsValid)
            {
                // Process the reservation (e.g., save to database)
                TempData["SuccessMessage"] = "Your reservation has been submitted successfully!";
                return RedirectToAction("BookingPage", "Booking");
            }

            // Return the same view with validation errors
            return View(model);
        }
    }
}