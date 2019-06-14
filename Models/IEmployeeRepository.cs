using System.Collections.Generic;
namespace aspnetcoreNewWeb.Models
{
    public interface IEmployeeRepository
    {
      Employee GetEmployee(int id);  
      IEnumerable<Employee> GetAllEmployee();
    }
}