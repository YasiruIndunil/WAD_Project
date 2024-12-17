using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using TheGalleryCafe.Models;
using System.Data.SqlClient;


namespace TheGalleryCafe.Class
{
    public class ClsMealItem
    {
        SqlParameter[] cl;

        public List<TypesOfMeals> GetMealTypeList()
        {
            List<TypesOfMeals> mealTypes = new List<TypesOfMeals>();  // Initialize a list to store multiple TypesOfMeals

            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetMealTypeList", new SqlParameter[] { }))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        TypesOfMeals Mtype = new TypesOfMeals
                        {
                            MealTypeID = int.Parse(dr1["MealTypeID"].ToString()),
                            MealTypeName = dr1["MealTypeName"].ToString(),
                            Description = dr1["Description"].ToString(),
                            ImageUrl = dr1["ImageUrl"].ToString()
                        };

                        mealTypes.Add(Mtype);  // Add each TypesOfMeals object to the list
                    }
                }
            }

            return mealTypes;  // Return the list of TypesOfMeals
        }




        public List<MealItemViewModel> GetMenu(string MealItemID)
        {
            List<MealItemViewModel> mealTypes = new List<MealItemViewModel>();  // Initialize the list to store MealItem objects
            SqlParameter[] cl = new SqlParameter[1];
            cl[0] = new SqlParameter("@MealItemID", SqlDbType.Int);
            cl[0].Value = MealItemID;

            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetMenu", cl))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        MealItemViewModel _MealItem = new MealItemViewModel();
                        _MealItem.MealItemID = int.Parse(dr1["MealItemID"].ToString());
                        _MealItem.CuisineName = dr1["CuisineName"].ToString();
                        _MealItem.DishName = dr1["DishName"].ToString();
                        _MealItem.Description = dr1["Description"].ToString();
                        _MealItem.Price = decimal.Parse(dr1["Price"].ToString());
                        _MealItem.ImageUrl = dr1["ImageUrl"].ToString();

                        mealTypes.Add(_MealItem);  // Add each MealItem to the list
                    }
                }
            }

            return mealTypes;  // Return the list of MealItem objects
        }



    }
}