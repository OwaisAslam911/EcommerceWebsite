using EcommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EcommerceWebsiteContext context;
        private readonly IHttpContextAccessor accessor;

        public HomeController(ILogger<HomeController> logger, EcommerceWebsiteContext context, IHttpContextAccessor accessor)
        {
            _logger = logger;
            this.context = context;
            this.accessor = accessor;
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
        [HttpPost]
        public IActionResult Contact(Review review)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
         public IActionResult FAQ()
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
        public IActionResult Signup()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Signup(User adduser )
        {
            var name = context.Users.Where(option => option.UserName == adduser.UserName).FirstOrDefault();
            var email = context.Users.Where(option => option.UserEmail == adduser.UserEmail).FirstOrDefault();
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
