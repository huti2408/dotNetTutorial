using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DotNetTutorial.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["id"] = id;
            ViewData["message"] = "Hello  " + name;
            return View();
        }
    }
}
