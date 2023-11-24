using Microsoft.AspNetCore.Mvc;

namespace ncs1.Controllers.UserMgt
{
    public class UserMgtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
