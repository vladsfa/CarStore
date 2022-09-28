using CarStore.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CarStore.WebUI.Models.Abstract;

namespace CarStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICarContext _context;

        public HomeController(ICarContext carContext)
        {
            _context = carContext;
        }

        public IActionResult Index()
        {
            return View(_context.Brands);
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