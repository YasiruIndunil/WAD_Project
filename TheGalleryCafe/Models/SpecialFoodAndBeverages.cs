using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class SpecialFoodAndBeverages
    {
        public int SpecialID { get; set; } 
        public string SpecialName { get; set; } 
        public int CategoryID { get; set; } 
        public string Description { get; set; } 
        public decimal Price { get; set; } 

    }
}