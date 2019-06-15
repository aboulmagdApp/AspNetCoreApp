using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    public class DepartmentsController : Controller
{
    public string List()
    {
        return "List() of DepartmentsController";
    }

    public string Details()
    {
        return "Details() of DepartmentsController";
    }
}
}