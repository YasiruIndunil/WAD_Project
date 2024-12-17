using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TheGalleryCafe.Models;
using System.Data.SqlClient;

namespace TheGalleryCafe.Class
{
    public class ClsOrder
    {


        SqlParameter[] cl;


        public List<CartViewModel> ChangeAddedItemsQty(int ID, string Type)
        {
            List<CartViewModel> mealTypes = new List<CartViewModel>();  // Initialize the list to store MealItem objects
            SqlParameter[] cl = new SqlParameter[3];
            cl[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            cl[0].Value = ID;
            cl[1] = new SqlParameter("@Type", SqlDbType.VarChar, 50);
            cl[1].Value = Type;
            cl[2] = new SqlParameter("@trnUser", SqlDbType.VarChar, 50);
            cl[2].Value = HttpContext.Current.User.Identity.Name;


            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "ChangeAddedItemsQty", cl))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        CartViewModel _MealItem = new CartViewModel();
                        _MealItem.UserID = dr1["UserID"].ToString();
                        _MealItem.ImageUrl = dr1["ImageUrl"].ToString();
                        _MealItem.MealItemID = int.Parse(dr1["MealItemID"].ToString());
                        _MealItem.CartItemID = int.Parse(dr1["CartItemID"].ToString());
                        _MealItem.DishName = dr1["DishName"].ToString();
                        _MealItem.Quantity = int.Parse(dr1["Quantity"].ToString());
                        _MealItem.Subtotal = decimal.Parse(dr1["Subtotal"].ToString());
                        _MealItem.GrandTotal = decimal.Parse(dr1["GrandTotal"].ToString());
                        _MealItem.TotalQuantity = int.Parse(dr1["TotalQuantity"].ToString());

                        mealTypes.Add(_MealItem);  // Add each MealItem to the list
                    }
                }
            }

            return mealTypes;  // Return the list of MealItem objects
        }


        public List<CartViewModel> AddCart(string MenuID)
        {
            List<CartViewModel> mealTypes = new List<CartViewModel>();  // Initialize the list to store MealItem objects
            SqlParameter[] cl = new SqlParameter[2];
            cl[0] = new SqlParameter("@MenuID", SqlDbType.Int);
            cl[0].Value = MenuID;
            cl[1] = new SqlParameter("@trnUser", SqlDbType.VarChar, 50);
            cl[1].Value = HttpContext.Current.User.Identity.Name;


            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "AddToCart", cl))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        CartViewModel _MealItem = new CartViewModel();
                        _MealItem.UserID = dr1["UserID"].ToString();
                        _MealItem.ImageUrl = dr1["ImageUrl"].ToString();
                        _MealItem.MealItemID = int.Parse(dr1["MealItemID"].ToString());
                        _MealItem.CartItemID = int.Parse(dr1["CartItemID"].ToString());
                        _MealItem.DishName = dr1["DishName"].ToString();
                        _MealItem.Quantity = int.Parse(dr1["Quantity"].ToString());
                        _MealItem.Subtotal = decimal.Parse(dr1["Subtotal"].ToString());
                        _MealItem.GrandTotal = decimal.Parse(dr1["GrandTotal"].ToString());
                        _MealItem.TotalQuantity = int.Parse(dr1["TotalQuantity"].ToString());

                        mealTypes.Add(_MealItem);  // Add each MealItem to the list
                    }
                }
            }

            return mealTypes;  // Return the list of MealItem objects
        }


        public List<CartViewModel> AddedCartItemList()
        {
            List<CartViewModel> mealTypes = new List<CartViewModel>();  // Initialize the list to store MealItem objects
            SqlParameter[] cl = new SqlParameter[1];
 
            cl[0] = new SqlParameter("@trnUser", SqlDbType.VarChar, 50);
            cl[0].Value = HttpContext.Current.User.Identity.Name;


            // Execute stored procedure and read data
            using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "AddedCartItemList", cl))
            {
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        CartViewModel _MealItem = new CartViewModel();
                        _MealItem.UserID = dr1["UserID"].ToString();
                        _MealItem.ImageUrl = dr1["ImageUrl"].ToString();
                        _MealItem.MealItemID = int.Parse(dr1["MealItemID"].ToString());
                        _MealItem.CartItemID = int.Parse(dr1["CartItemID"].ToString());
                        _MealItem.DishName = dr1["DishName"].ToString();
                        _MealItem.Quantity = int.Parse(dr1["Quantity"].ToString());
                        _MealItem.Subtotal = decimal.Parse(dr1["Subtotal"].ToString());
                        _MealItem.GrandTotal = decimal.Parse(dr1["GrandTotal"].ToString());
                        _MealItem.TotalQuantity = int.Parse(dr1["TotalQuantity"].ToString());

                        mealTypes.Add(_MealItem);  // Add each MealItem to the list
                    }
                }
            }

            return mealTypes;  // Return the list of MealItem objects
        }



    
        //public List<CartViewModel> GetAddedItems()
        //{
        //    List<CartViewModel> mealTypes = new List<CartViewModel>();  // Initialize the list to store MealItem objects
        //    SqlParameter[] cl = new SqlParameter[1];
        //    cl[0] = new SqlParameter("@trnUser", SqlDbType.VarChar, 50);
        //    cl[0].Value = HttpContext.Current.User.Identity.Name;


        //    // Execute stored procedure and read data
        //    using (SqlDataReader dr1 = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "GetCartAddedItems", cl))
        //    {
        //        if (dr1.HasRows)
        //        {
        //            while (dr1.Read())
        //            {
        //                CartViewModel _MealItem = new CartViewModel();
        //                _MealItem.UserID = dr1["UserID"].ToString();
        //                _MealItem.CartItemID = int.Parse(dr1["CartItemID"].ToString());
        //                _MealItem.DishName = dr1["DishName"].ToString();
        //                _MealItem.Quantity = int.Parse(dr1["Quantity"].ToString());
        //                _MealItem.Subtotal = decimal.Parse(dr1["Subtotal"].ToString());


        //                mealTypes.Add(_MealItem);  // Add each MealItem to the list
        //            }
        //        }
        //    }

        //    return mealTypes;  // Return the list of MealItem objects
        //}


    }
}