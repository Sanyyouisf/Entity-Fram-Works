using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPWithCodeApproach
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //to map this employee entity -that we pass it - to use the stored procedure
            //modelBuilder.Entity<Employee>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }
    }
}