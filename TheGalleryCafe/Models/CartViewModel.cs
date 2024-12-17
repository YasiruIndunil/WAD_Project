using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class CartViewModel 
    {

        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int MealItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        public string UserID { get; set; }
        public string ImageUrl { get; set; }
        public string DishName { get; set; }

        public decimal GrandTotal { get; set; }
        public int TotalQuantity { get; set; }
    }
}