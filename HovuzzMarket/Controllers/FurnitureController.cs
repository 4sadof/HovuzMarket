using EdgeCut.DAL;
using EdgeCut.Models;
using EdgeCut.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdgeCut.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly ApplicationContext _context;
        public FurnitureController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Page = "Furniture";
            List<Furniture> furnites = _context.Furnitures
                        .Where(x => x.DeletedAt == null)
                        .ToList();
            FurnitureVM furnitureVM = new FurnitureVM()
            {
                Furnitures = furnites
            };
           
            return View(furnitureVM);
        }
    }
}
