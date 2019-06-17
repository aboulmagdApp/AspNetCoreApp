using Microsoft.EntityFrameworkCore;

namespace aspnetcoreNewWeb.Models
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                  Id=1,
                  Name="Mohamed aboulmagd",
                  Email="aboulmagd@live.com",
                   Department=Dept.IT     
                },
                 new Employee
                {
                  Id=2,
                  Name="Ahmed Hossam",
                  Email="Ahmed@Outlook.com",
                   Department=Dept.Payroll     
                },
                 new Employee
                {
                  Id=3,
                  Name="shadi hussan",
                  Email="shadi@gmail.com",
                   Department=Dept.HR     
                },
                 new Employee
                {
                  Id=4,
                  Name="Eman Abdallah",
                  Email="Eman@gmail.com",
                   Department=Dept.IT     
                }
            );
        }
    }
}