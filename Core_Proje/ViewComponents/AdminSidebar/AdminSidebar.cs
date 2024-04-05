using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.AdminNavbar
{
    public class AdminSidebar:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public AdminSidebar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.ImageUrl;
            ViewBag.v2 = values.Name + " " + values.Surname;
            return View();
        }
    }
}
