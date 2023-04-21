using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopulerDestinations:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList().Take(10).ToList();
            return View(values);
        }
    }
}
