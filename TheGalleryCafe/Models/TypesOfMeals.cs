using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class TypesOfMeals
    {
        [Key]
        public int MealTypeID { get; set; } 
        public string MealTypeName { get; set; } 
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; } 

    }
}