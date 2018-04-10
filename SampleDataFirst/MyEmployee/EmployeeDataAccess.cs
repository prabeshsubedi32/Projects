using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEmployee
{
    public class EmployeeDataAccess
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext data = new EmployeeDBContext();
            return data.Departments.Include("Employees").ToList();

        }
    }
}