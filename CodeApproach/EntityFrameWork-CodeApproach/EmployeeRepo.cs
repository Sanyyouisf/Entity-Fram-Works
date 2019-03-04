using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeApproach
{
    //this class will contain our methodes which return the data that we want.
    public class EmployeeRepo
    {
        public List<Department> GetDepartmentsList()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.Include("Employees").ToList();
        }
    }
}