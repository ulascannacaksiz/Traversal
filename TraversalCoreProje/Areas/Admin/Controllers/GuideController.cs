using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide/[action]/{id?}")]
    public class GuideController : Controller
    {
        public void AlertShow(string type, string subject, string message)
        {
            TempData["Type"] = type;
            TempData["Subject"] = subject;
            TempData["Description"] = message;
        }
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
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
                AlertShow("success", "Başarılı", "Yeni Rehber Başarıyla Eklendi!");
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                AlertShow("error", "Başarısız", "Rehber eklenemedi!");
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
            AlertShow("success", "Başarılı", "Rehber Bilgisi Başarıyla Güncellendi!");
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(int id)
        {
            var values = _guideService.TGetById(id);
            values.Status = !values.Status;
            _guideService.TUpdate(values);
            AlertShow("success", "Başarılı", "Rehber durumu güncellendi!");
            return RedirectToAction("Index");
        }
    }
}
