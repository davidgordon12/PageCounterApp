using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;
using PageCounterApp.Models;
namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        public  IPageCounter countService;
        public HomeController(IPageCounter _countService) 
        {
            countService = _countService;
        }

        public IActionResult Index()
        {
            int count = countService.IncrementPageCount("Index");
            return View("Index", count);
        }

        public IActionResult Page2()
        {
            int count = countService.IncrementPageCount("Page2");
            return View("Page2", count);
        }
    }
}