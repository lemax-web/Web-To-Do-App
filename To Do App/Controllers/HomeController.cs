using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using To_Do_App.Models;
using TodoApp.Data;
using TodoApp.Models;

namespace To_Do_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        TodoDbContext _todoDbContext;
        public HomeController(ILogger<HomeController> logger,TodoDbContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.Todos = _todoDbContext.Todo.Where(c => c.IsCompleted == false).ToList();
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