using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProje.Areas.Admin.Models;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide/[action]/{id?}")]
    [AllowAnonymous]
    public class GuideController : Controller
    {

        private readonly IGuideService _guideService;
        private readonly IAlertService _alertService;
        private readonly IDataProtector _dataProtector;

        public GuideController(IGuideService guideService, IAlertService alertService, IDataProtectionProvider dataProtectorProvider)
        {
            _guideService = guideService;
            _alertService = alertService;
            _dataProtector = dataProtectorProvider.CreateProtector("protectorname1");
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            List<GuideViewModel> a = new List<GuideViewModel>();
            a = values.Select(x => new GuideViewModel
            {
                Name = x.Name,
                GuideId = x.GuideId,
                Description = x.Description,
                Image = x.Image,
                Status = x.Status,
                TwitterUrl = x.TwitterUrl,
                InstagramUrl = x.InstagramUrl,
                EncryptedId = _dataProtector.Protect(x.GuideId.ToString())
            }).ToList();


            return View(a);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator guideValidator = new GuideValidator();
            ValidationResult result = guideValidator.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                _alertService.ShowAlert("success", "Başarılı", "Yeni Rehber Başarıyla Eklendi!");

                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                _alertService.ShowAlert("error", "Başarısız", "Rehber eklenemedi!");
                return View();
            }

        }


        [HttpGet]
        public IActionResult EditGuide(string id)
        {
            int DecryptId = int.Parse(_dataProtector.Unprotect(id));
            var values = _guideService.TGetById(DecryptId);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            _alertService.ShowAlert("success", "Başarılı", "Rehber Bilgisi Başarıyla Güncellendi!");
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(string id)
        {
            int DecryptId = int.Parse(_dataProtector.Unprotect(id));
            var values = _guideService.TGetById(DecryptId);
            values.Status = !values.Status;
            _guideService.TUpdate(values);
            _alertService.ShowAlert("success", "Başarılı", "Rehber durumu güncellendi!");
            return RedirectToAction("Index");
        }
    }
}
