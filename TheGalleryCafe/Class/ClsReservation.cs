using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TheGalleryCafe.Models;
using System.Data.SqlClient;

namespace TheGalleryCafe.Class
{
    public class ClsReservation
    {
        SqlParameter[] cl;



        public string GetEmailByUsername(string username)
        {
            string email = null;

            string query = "SELECT Email FROM AspNetUsers WHERE UserName = @UserName";
            SqlParameter[] parameters = {
        new SqlParameter("@UserName", SqlDbType.VarChar) { Value = username }
            };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(clsConnectionString.getConnectionString(), CommandType.Text, query, parameters))
            {
                if (reader.Read())
                {
                    email = reader["Email"]?.ToString();
                }
            }

            return email;
        }



        public string TableReservation(Reservation rese)
        {
            cl = new SqlParameter[8];
            string username = HttpContext.Current.User.Identity.Name;

            // Assuming you have a method to fetch email by username
            string userEmail = GetEmailByUsername(username);

            cl[0] = new SqlParameter("@CustomerName", SqlDbType.VarChar, 100);
            cl[0].Value = rese.CustomerName;
            cl[1] = new SqlParameter("@ContactNumber", SqlDbType.VarChar, 100);
            cl[1].Value = rese.ContactNumber;
            cl[2] = new SqlParameter("@Email", SqlDbType.VarChar, 100);
            cl[2].Value = userEmail;
            cl[3] = new SqlParameter("@ReservationDate", SqlDbType.VarChar, 150);
            cl[3].Value = rese.ReservationDate; ;
            cl[4] = new SqlParameter("@NumberOfGuests", SqlDbType.Int);
            cl[4].Value = rese.NumberOfGuests;
            cl[5] = new SqlParameter("@SpecialRequests", SqlDbType.VarChar, 150);
            cl[5].Value = rese.SpecialRequests;
            cl[6] = new SqlParameter("@trnUser", SqlDbType.VarChar, 50);
            cl[6].Value = HttpContext.Current.User.Identity.Name;
            cl[7] = new SqlParameter("@TableNumber", SqlDbType.Int);
            cl[7].Value = rese.TableNumber;

            try
            {
                var res = SqlHelper.ExecuteNonQuery(clsConnectionString.getConnectionString(), CommandType.StoredProcedure, "TableReservation", cl);

                if (res == -1)
                {
                    return "User Update successfully";
                }
                else
                {
                    return "Update failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }



    }
}