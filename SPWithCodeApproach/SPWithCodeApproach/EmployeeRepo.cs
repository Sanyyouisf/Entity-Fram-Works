using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPWithCodeApproach
{
    public class EmployeeRepo
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        //get
        public List<Employee> GetEmployee()
        {
            return employeeDBContext.Employees.ToList();
        }

        //insert
        public void AddEmployee (Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            //important to call this method to save the cahanges to the database.
            employeeDBContext.SaveChanges();
        }

        //update
        public void UpdateEmployee( Employee employee)
        {
            Employee empToUpdate = employeeDBContext.Employees.Find(employee.ID);

            empToUpdate.ID = employee.ID;
            empToUpdate.FirstName = employee.FirstName;
            empToUpdate.LastName = employee.LastName;
            empToUpdate.Salary = employee.Salary;
            empToUpdate.Gender = employee.Gender;

            employeeDBContext.SaveChanges();
        }

        //delete
        public void DeleteEmployee(int id)
        {
            Employee empToDelete = employeeDBContext.Employees.Find(id);
            employeeDBContext.Employees.Remove(empToDelete);
        }
    }
}