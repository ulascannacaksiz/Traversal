using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide/[action]/{id?}")]
    [AllowAnonymous]
    public class GuideController : Controller
    {

        private readonly IGuideService _guideService;
        private readonly IAlertService _alertService;

        public GuideController(IGuideService guideService, IAlertService alertService)
        {
            _guideService = guideService;
            _alertService = alertService;
        }

        public IActionResult Index()
        {           
            var values = _guideService.TGetList();
            return View(values);
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
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                _alertService.ShowAlert("error", "Başarısız", "Rehber eklenemedi!");
                return View();
            }

        }


        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            _alertService.ShowAlert("success", "Başarılı", "Rehber Bilgisi Başarıyla Güncellendi!");
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(int id)
        {
            var values = _guideService.TGetById(id);
            values.Status = !values.Status;
            _guideService.TUpdate(values);
            _alertService.ShowAlert("success", "Başarılı", "Rehber durumu güncellendi!");
            return RedirectToAction("Index");
        }
    }
}
