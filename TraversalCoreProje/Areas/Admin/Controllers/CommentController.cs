using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class CommentController : Controller
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());
        //Yukarıda ki bağımlılığın kaldırılması için yaptık
        //startup.cs den yapılandırma yapmak gerekli
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
