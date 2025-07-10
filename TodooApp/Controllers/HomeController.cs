using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodooApp.Models;


namespace TodooApp.Controllers
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

            //  creating a list  Todo item
            var todos = new List<Todo>
            {
                new Todo
                {
                    Id =1,
                    Title ="Learn .net basics",
                    IsDone = false
                },

                new Todo
                {
                    Id =2,
                    Title ="Build first project",
                    IsDone =false
                },

                new Todo
                {
                    Id = 3,
                    Title = "Show this lisyt in view",
                    IsDone = false

                }


            };

            return View( todos);
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
