using EdgeCut.DAL;
using EdgeCut.Models;
using EdgeCut.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdgeCut.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationContext _context;
        public BlogController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Page = "Blog";
            List<Blog> blogs = _context.Blogs
                        .Where(x => x.DeletedAt == null)
                        .ToList();
            BlogVM blogVM = new BlogVM()
            {
               Blogs= blogs
            };
            return View(blogVM);
        }
    }
}
