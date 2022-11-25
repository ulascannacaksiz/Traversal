﻿using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Presentation;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;
                announcementListViewModel.Id = item.AnnouncementId;

                model.Add(announcementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(string a)
        {
            return View();
        }
    }
}