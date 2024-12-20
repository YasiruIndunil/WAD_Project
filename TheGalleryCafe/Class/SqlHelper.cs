using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace TheGalleryCafe.Class
{
    public static class SqlHelper
    {
        // Your methods to interact with the database
        public static SqlConnection GetConnection()
        {
            string connectionString = "DefaultConnection";
            return new SqlConnection(connectionString);
        }

        // Other methods to execute SQL commands

        // Method to execute a SQL query and return a SqlDataReader
        // Method to execute a SQL query and return a SqlDataReader
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);  // Add parameters to command
            }

            try
            {
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                // Log or handle exceptions as needed
                throw new Exception("Error executing SQL query", ex);
            }
        }


        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    if (commandParameters != null)
                    {
                        command.Parameters.AddRange(commandParameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }


    }

}