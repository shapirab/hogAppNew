using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HouseID { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        public int Points { get; set; }
    }
}