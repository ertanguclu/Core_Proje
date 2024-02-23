using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
