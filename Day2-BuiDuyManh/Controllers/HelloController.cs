using Microsoft.AspNetCore.Mvc;

namespace Day2_BuiDuyManh.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Bài cũ
        public IActionResult Welcome(string name = "manh", int numTimes = 5)
        {
            ViewBag.Message = "Hello " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }

        // Bài ViewComponent mới
        public IActionResult GreetingDemo()
        {
            return View();
        }
    }
}