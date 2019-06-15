using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    [Route("[Controller]")]
    public class DepartmentsController : Controller
{
    [Route("")]
    [Route("[action]")]
    public string List()
    {
        return "List() of DepartmentsController";
    }

    [Route("[action]")]
    public string Details()
    {
        return "Details() of DepartmentsController";
    }
}
}