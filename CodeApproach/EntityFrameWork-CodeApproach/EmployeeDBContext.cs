using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeApproach
{
    //the DbContext class do all the work to retrive and save data from and to the database.
    public class EmployeeDBContext:DbContext
    {
        // this 'Employees' property will return a DbSet of Employee Objects
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}