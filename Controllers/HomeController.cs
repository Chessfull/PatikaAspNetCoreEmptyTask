using Microsoft.AspNetCore.Mvc;

namespace PatikaAspNetCoreEmptyTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
