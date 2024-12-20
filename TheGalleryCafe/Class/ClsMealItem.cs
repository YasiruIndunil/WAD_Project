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



        public List<Cuisines> GetAllCuisines()
        {
            List<Cuisines> mealTypes = new List<Cuisines>();  // Initialize a list to store multiple TypesOfMeals

            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetAllCuisines", new SqlParameter[] { }))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        Cuisines CList = new Cuisines
                        {
                            CuisineID = int.Parse(dr1["CuisineID"].ToString()),
                            CuisineName = dr1["CuisineName"].ToString(),
                            ImageUrl = dr1["CuisineName"].ToString() + ".jpg"
                        };

                        mealTypes.Add(CList);  // Add each TypesOfMeals object to the list
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
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetPopularMenu", cl))
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

        public List<Promotion> GetPromo()
        {
            List<Promotion> mealTypes = new List<Promotion>();  // Initialize the list to store MealItem objects

 
            // Execute stored procedure and read data

            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetPromotions", new SqlParameter[] { }))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        Promotion _MealItem = new Promotion();
                        _MealItem.PromotionID = int.Parse(dr1["PromotionID"].ToString());
                        _MealItem.Title = dr1["Title"].ToString();
                        _MealItem.Description = dr1["Description"].ToString();
                        _MealItem.ImageUrl = dr1["ImageUrl"].ToString();
                        DateTime startDate, endDate;
                        if (DateTime.TryParse(dr1["StartDate"].ToString(), out startDate))
                        {
                            _MealItem.StartDate = startDate;
                        }
                        if (DateTime.TryParse(dr1["EndDate"].ToString(), out endDate))
                        {
                            _MealItem.EndDate = endDate;
                        }

                        mealTypes.Add(_MealItem);  // Add each MealItem to the list
                    }
                }
            }

            return mealTypes;  // Return the list of MealItem objects
        }



        public List<MealItemViewModel> GetCuisin(string CID)
        {
            List<MealItemViewModel> mealTypes = new List<MealItemViewModel>();  // Initialize the list to store MealItem objects
            SqlParameter[] cl = new SqlParameter[1];
            cl[0] = new SqlParameter("@CuisinesID", SqlDbType.Int);
            cl[0].Value = CID;

            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetAllMenu", cl))
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