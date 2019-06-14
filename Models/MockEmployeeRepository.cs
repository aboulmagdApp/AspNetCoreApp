using System;
using System.Collections.Generic;
using System.Linq;

namespace aspnetcoreNewWeb.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                    new Employee(){Id=1,Name="Mary",Email="mary@live.com"},
                    new Employee(){Id=2,Name="aboulmagd",Email="aboulmagd@live.com"},
                    new Employee(){Id=3,Name="hany",Email="hany@live.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}