using Microsoft.AspNetCore.Mvc;
namespace EcommerceWebsite.Controllers
{
    public class AdminController1 : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
