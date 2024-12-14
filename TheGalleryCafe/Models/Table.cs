using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        public string TableNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public bool ParkingAvailability { get; set; }
        public string  Location { get; set; }
        public string Notes { get; set; }

        //public string ImageUrl { get; set; }
    }
}