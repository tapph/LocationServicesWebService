using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LocationServicesWebService.DAL
{
    public class SQLConnection
    {

        /// <summary>
        /// Get's the SQL connection string from the web config
        /// </summary>
        /// <returns>SQL Connection String</returns>
        public string SQLConnectionString()
        {

            string connstring = null;

            connstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return connstring;

        }
    }
}