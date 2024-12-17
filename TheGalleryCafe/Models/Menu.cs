using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int MealItemID { get; set; }  // Foreign key for MealItems
        public int MealTypeID { get; set; }  // Foreign key for MealTypes
        public bool IsActive { get; set; }

        // Navigation properties (EF will automatically handle the relationships)
        public MealItem MealItem { get; set; }
        public TypesOfMeals MealType { get; set; }
    }

}