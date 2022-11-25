using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TraversalCoreProje.Areas.Admin.Models;
using Destination = EntityLayer.Concrete.Destination;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Destination/[action]/{id?}")]
    public class DestinationController : Controller
    {
        //DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly IDestinationService _destinationService;
        private readonly IDataProtector _dataProtector;

        public DestinationController(IDestinationService destinationService, IDataProtectionProvider dataProtectorProvider)
        {
            _destinationService = destinationService;
            _dataProtector = dataProtectorProvider.CreateProtector("protectorname1");
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            List<DestinationViewModel> destinationViewModels = new List<DestinationViewModel>();
            destinationViewModels = values.Select(x => new DestinationViewModel
            {
                DestinationId = x.DestinationId,
                Capacity = x.Capacity,
                City = x.City,
                DayNight = x.DayNight,
                Price = x.Price,
                Image = x.Image,
                Description = x.Description,
                CoverImage = x.CoverImage,
                Details1 = x.Details1,
                Details2 = x.Details2,
                Image2 = x.Image2,
                EncryptedId = _dataProtector.Protect(x.DestinationId.ToString())
            }).ToList(); ;
            return View(destinationViewModels);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(string id)
        {
            int decryptId = int.Parse(_dataProtector.Unprotect(id));
            var values = _destinationService.TGetById(decryptId);
            _destinationService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(string id)
        {
            int decryptId = int.Parse(_dataProtector.Unprotect(id));
            var values = _destinationService.TGetById(decryptId);
            return View(values);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
