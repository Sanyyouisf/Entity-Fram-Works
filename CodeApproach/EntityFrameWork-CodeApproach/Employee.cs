﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeApproach
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }

        public virtual Department Department { get; set; }
    }
}