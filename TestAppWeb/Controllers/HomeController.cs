using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestAppWeb.Data;
using TestAppWeb.Models;

namespace TestAppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //vaka pristapuvame do database object
        //poradi DI(Dependency Injection) ne mora da kreiram object od class bidejki vekje e konfigurirano vo Program.cs (objektot vekje postoi)

        private readonly ApplicationDbContext _db;

        
        [ActivatorUtilitiesConstructor] 
        public HomeController(ApplicationDbContext db)
        {
            _db = db;   
        }



        public IActionResult Index()
        {
            IEnumerable<Hierarchy> objHierarchiesList = _db.Hierarchies.ToList();
            return View(objHierarchiesList);
        }

        public IActionResult Plan()
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