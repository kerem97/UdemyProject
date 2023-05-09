using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult _PreloaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _NavHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }

    }
}
