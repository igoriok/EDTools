using Microsoft.AspNetCore.Mvc;

namespace ED.Importer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}