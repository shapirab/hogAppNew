﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogApp
{
    public class Faculty
    {
        public int FacID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}