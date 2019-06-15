using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    [Route("Departments")]
    public class DepartmentsController : Controller
{
    [Route("")]
    [Route("List")]
    public string List()
    {
        return "List() of DepartmentsController";
    }

    [Route("Details")]
    public string Details()
    {
        return "Details() of DepartmentsController";
    }
}
}