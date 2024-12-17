using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Class;
using TheGalleryCafe.Models;

namespace TheGalleryCafe.Controllers
{
    public class OrderingController : Controller
    {

        ClsOrder _ClsOrder = new ClsOrder();


        // GET: Ordering
        public ActionResult OrderView()
        {
            ViewBag.OrderList = _ClsOrder.AddedCartItemList();
            return View();
        }

        public ActionResult OrderViewList()
        {
            ViewBag.OrderList = _ClsOrder.AddedCartItemList();
            // Retrieve the OrderList
            var result = _ClsOrder.AddedCartItemList();
            foreach (var itemData in result)
            {
                ViewBag.GrandTotal = itemData.GrandTotal; // Total price
                ViewBag.TotalQuantity = itemData.TotalQuantity; // Total quantity
            }

            return PartialView("OrderViewList");
        }

        [Authorize]
        [HttpPost]
        public JsonResult ChangeItemsQty(int ID, string Type )
        {
            var cartData = _ClsOrder.ChangeAddedItemsQty(ID, Type); // Fetch the cart data after adding the item
            return Json(cartData); // Return the updated cart data as JSON

        }
        
        
        
        
        
        [Authorize]
        [HttpPost]
        public JsonResult AddToCart(string MenuID)
        {

            if (string.IsNullOrEmpty(MenuID))
            {
                return Json(new { success = false, message = "Invalid MenuID" });
            }

            try
            {
                var cartData = _ClsOrder.AddCart(MenuID); // Fetch the cart data after adding the item
                return Json(cartData); // Return the updated cart data as JSON
            }
            catch (Exception ex)
            {
                // Log the exception (if logging is implemented)
                return Json(new { success = false, message = "Error adding to cart", error = ex.Message });
            }
 
        }

 
        [Authorize]
        public JsonResult AddedCartItems()
        {
            try
            {
                var cartData = _ClsOrder.AddedCartItemList(); // Fetch the cart data after adding the item
                return Json(cartData); // Return the updated cart data as JSON
            }
            catch (Exception ex)
            {
                // Log the exception (if logging is implemented)
                return Json(new { success = false, message = "Error adding to cart", error = ex.Message });
            }

        }




        //[HttpPost]
        //public JsonResult RemoveItem(int id)
        //{
        //    bool isRemoved = _ClsOrder.RemoveItemById(id); // Implement item removal logic
        //    return Json(new { success = isRemoved });
        //}



    }
}