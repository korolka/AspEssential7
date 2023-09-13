using Microsoft.AspNetCore.Mvc;

namespace Ex2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ShowSquare()
        {
            return View();
        }
    }
}
