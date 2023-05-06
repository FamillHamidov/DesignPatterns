using DesignPattern.TemplateMethod.Models;
using DesignPattern.TemplateMethod.TemplateMethod;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public IActionResult FireFighter()
        {
            Worker worker = new FireFighter();
            ViewBag.v1 = worker.GetUp("07:00");
            ViewBag.v2 = worker.Breakfast("07:30 -- 07:55");
            ViewBag.v3 = worker.GoToWork("08:00 -- 08:55");
            ViewBag.v4 = worker.WorkTime("09:00 -- 23:00");
            ViewBag.v5 = worker.ReturnHome("00:00 -- 00:55");
            ViewBag.v6 = worker.Relax("01:00 -- 03:00");
            ViewBag.v7 = worker.Sleep("04:00");
            return View();
        }
        public IActionResult Manager()
        {
            Worker worker = new Manager();
            ViewBag.v1 = worker.GetUp("07:00");
            ViewBag.v2 = worker.Breakfast("07:30 -- 07:55");
            ViewBag.v3 = worker.GoToWork("08:00 -- 08:55");
            ViewBag.v4 = worker.WorkTime("09:00 -- 16:00");
            ViewBag.v5 = worker.ReturnHome("16:00 -- 16:55");
            ViewBag.v6 = worker.Relax("17:00 -- 22:00");
            ViewBag.v7 = worker.Sleep("22:00 -- 07:00");
            return View();
        }
        public IActionResult Postman()
        {
            Worker worker = new Postman();
            ViewBag.v1 = worker.GetUp("06:00");
            ViewBag.v2 = worker.Breakfast("06:30 -- 06:55");
            ViewBag.v3 = worker.GoToWork("07:00 -- 07:30");
            ViewBag.v4 = worker.WorkTime("07:30 -- 16:00");
            ViewBag.v5 = worker.ReturnHome("16:00 -- 16:30");
            ViewBag.v6 = worker.Relax("16:30 -- 20:00");
            ViewBag.v7 = worker.Sleep("20:00 -- 06:00");
            return View();
        }
    }
}