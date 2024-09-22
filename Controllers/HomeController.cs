using EcommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceWebsite.Controllers
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
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        } 
        public IActionResult Shop()
        {
            return View();
        }  
        public IActionResult Store()
        {
            return View();
        }
        public IActionResult StoreList()
        {
            return View();
        }   
        public IActionResult Login()
        {
            return View();
        } 
        public IActionResult BecomeSeller()
        {
            return View();
        } 
        public IActionResult ErrorPage()
        {
            return View();
        } 
        public IActionResult ComingSoom()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        } 
        public IActionResult Checkout()
        {
            return View();
        } 
        public IActionResult Compare()
        {
            return View();
        } 
        public IActionResult Wishlist()
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
