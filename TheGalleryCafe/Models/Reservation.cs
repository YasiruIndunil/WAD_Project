using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class Reservation
    {

        public int ReservationID { get; set; } 
        public string CustomerName { get; set; } 
        public string ContactNumber { get; set; } 
        public string Email { get; set; } 
        public DateTime ReservationDate { get; set; }

        public int TableNumber { get; set; }
        public int NumberOfGuests { get; set; }
        public string SpecialRequests { get; set; }
        public bool IsConfirmed { get; set; }
    }
}