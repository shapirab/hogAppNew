using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace HogApp
{
    public class HouseDB
    {
        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HogDBConnectionString"].ConnectionString;
        }
        public static House getHouse(int houseID)
        {
            SqlConnection con = new SqlConnection(loadConnectionString());

            House house = new House();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from House where houseID='" + houseID + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    house.HouseID = Convert.ToInt32(reader.GetValue(0));
                    house.HouseName = reader.GetString(1);
                    house.HousePoints = Convert.ToInt32(reader.GetValue(2));
                }
            }
            return house;
        }
        public static void updateHousePoints(int points, int houseID)
        {
            SqlConnection con = new SqlConnection(loadConnectionString());
            using (con)
            {
                SqlCommand cmd = new SqlCommand("update House set housePoints ='" + points + "' where houseID ='" + houseID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static int getHousePoints(int houseID)
        {
            int housePoints = -99;
            SqlConnection con = new SqlConnection(loadConnectionString());
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select housePoints from House where houseID ='" + houseID + "'", con);
                con.Open();
                housePoints = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return housePoints;
        }
        private static List<House> loadAllSHouses()
        {
            List<House> houses = new List<House>();
            SqlConnection con = new SqlConnection(loadConnectionString());

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from House", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    House house = new House();
                    house.HouseID = Convert.ToInt32(reader.GetValue(0));
                    house.HouseName = reader.GetString(1);
                    house.HousePoints = Convert.ToInt32(reader.GetValue(2));
                    houses.Add(house);
                }
            }
            return houses;
        }
    }
}