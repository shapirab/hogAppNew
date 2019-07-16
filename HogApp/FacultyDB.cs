using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace HogApp
{
    public class FacultyDB
    {
        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HogDBConnectionString"].ConnectionString;
        }
        public static bool FacultyLogin(string userName, string password)
        {
            bool isFaculty = false;

            SqlConnection con = new SqlConnection(loadConnectionString());
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select count(*) from Faculty where userName='" + userName + "' and password='" + password + "'", con);
                con.Open();
                object results = cmd.ExecuteScalar();
                if (Convert.ToInt16(results) > 0)
                {
                    isFaculty = true;
                }

                return isFaculty;
            }
        }

    }
}