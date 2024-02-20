using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Writer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
