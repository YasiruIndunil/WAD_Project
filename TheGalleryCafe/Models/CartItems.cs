using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class CartItems
    {
        [Key]
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int MenuID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }


    }
}