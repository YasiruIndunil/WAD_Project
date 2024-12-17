using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class PreOrder
    {
        public int PreOrderID { get; set; }
        public int ReservationID { get; set; }
        public int MenuID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public string Notes { get; set; }


    }
}