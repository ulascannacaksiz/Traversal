using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.v1 = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            //p.DestinationId = 1;
            commentManager.TAdd(p);
            return PartialView();
        }
    }
}
