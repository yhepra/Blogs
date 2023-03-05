using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
