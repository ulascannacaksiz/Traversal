using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/ContactUs/[action]/{id?}")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IAlertService _alertService;

        public ContactUsController(IContactUsService contactUsService, IAlertService alertService)
        {
            _contactUsService = contactUsService;
            _alertService = alertService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.TGetListContactUsByTrue();
            return View(values);
        }
        public IActionResult ChangeToStatus(int id)
        {
            _contactUsService.TContactUsStatusChangeToFalse(id);
            _alertService.ShowAlert("sucess", "Başarılı", "Mesaj durumu güncellendi");
            return RedirectToAction("Index");
        }

    }
}
