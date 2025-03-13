using Microsoft.AspNetCore.Mvc;
namespace EcommerceWebsite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
