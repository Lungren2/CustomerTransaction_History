using ClientQuery.Models;
using CustomerTransaction_History.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CustomerTransaction_History.Controllers
{
    public class HomeController : Controller
    {
        public List<Clients> GetClients()
        {
            var Clients = new List<Clients>();
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            Clients.Add(new Clients() { ClientName = "John Doe", ClientBalance = -894.45f });
            return Clients;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var homeIndex = new HomeVM();
            return View(homeIndex);
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