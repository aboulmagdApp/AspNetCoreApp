using aspnetcoreNewWeb.Models;
using aspnetcoreNewWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("")]
        [Route("[action]")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        [Route("[action]/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}