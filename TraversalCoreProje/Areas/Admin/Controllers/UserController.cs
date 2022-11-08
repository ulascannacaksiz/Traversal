using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;
using Microsoft.AspNetCore.DataProtection;
using System.Linq;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly ICommentService _commentService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAlertService _alertService;
        private readonly IDataProtector _dataProtector;

        public UserController(IAppUserService appUserService, 
            ICommentService commentService, IReservationService reservationService, 
            UserManager<AppUser> userManager, IAlertService alertService, IDataProtectionProvider dataProtectorProvider)
        {
            _appUserService = appUserService;
            _commentService = commentService;
            _reservationService = reservationService;
            _userManager = userManager;
            _alertService = alertService;
            _dataProtector = dataProtectorProvider.CreateProtector("protectorname1");
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            List<UserListViewModel> userListViewModel = new List<UserListViewModel>();
            userListViewModel = values.Select(x => new UserListViewModel
            {
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                UserName = x.UserName,
                EncrytedId = _dataProtector.Protect(x.Id.ToString())
            }).ToList();
            return View(userListViewModel);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetById(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public async Task<IActionResult> EditUser(string id)//TODO
        {

            var user = await _userManager.FindByIdAsync(_dataProtector.Unprotect(id));
            EditUserViewModel editUserViewModel = new EditUserViewModel();
            editUserViewModel.Name = user.Name;
            editUserViewModel.Surname = user.Surname;
            editUserViewModel.PhoneNumber = user.PhoneNumber;
            editUserViewModel.Email = user.Email;
            //editUserViewModel.Id = user.Id;
            editUserViewModel.Id = _dataProtector.Protect(user.Id.ToString());
            return View(editUserViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel p)//TODO
        {
            var user = await _userManager.FindByIdAsync(_dataProtector.Unprotect(p.Id));
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PhoneNumber = p.PhoneNumber;
            if(p.Password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                _alertService.ShowAlert("success", "Başarılı", "Kullanıcı bilgisi başarıyla güncellendi");
                return RedirectToAction("Index");
            }
            _alertService.ShowAlert("danger", "Hata", "Kullanıcı bilgisi güncellenemedi");
            return View();
          
        }

        public IActionResult CommentUser(string id)//TODO: Burda bir ilişki yok ilişki yapılacak
        {
            int decrypedId = int.Parse(_dataProtector.Unprotect(id));
            var values = _commentService.TGetList();
            return View(values);
        }
        public IActionResult ReservationUser(string id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(int.Parse(_dataProtector.Unprotect(id)));
            return View(values);
        }
    }
}
