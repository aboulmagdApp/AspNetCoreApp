namespace aspnetcoreNewWeb.Models
{
    public interface IEmployeeRepository
    {
      Employee GetEmployee(int id);  
    }
}