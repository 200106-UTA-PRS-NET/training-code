using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloMvc.Models;

namespace HelloMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string Hello(){
            return "Hello MVC";
        }
        public ViewResult Page1(){
            return View("MainPage");
        }
        public IActionResult Index()
        {
            // view bag is a dynamic property in C#
            //ViewBag.Message="I am in index page"; 
            ViewData["Message"]="I am in index page";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
