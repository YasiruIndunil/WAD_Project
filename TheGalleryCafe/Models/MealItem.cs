﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class MealItem
    {
        public int MealItemID { get; set; }
        public int CuisineID { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }

}