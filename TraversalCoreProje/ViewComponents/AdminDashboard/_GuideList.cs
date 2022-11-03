using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _GuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
