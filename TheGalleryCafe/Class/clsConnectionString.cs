using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TheGalleryCafe.Class
{ 
    public class clsConnectionString
    {
        public clsConnectionString()
        {
        }

        public static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
