using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAE_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace FromAE_Final.Controllers
{
    public class CategoiesController : Controller
    {
        private readonly FromAeDbContext _context;

        public CategoiesController(FromAeDbContext context)
        {
            _context = context;
        }

        public IActionResult GetCategories( int id)
        {
            var category = _context.Categories.Where(x => x.SubMenuId == id).ToList();
            ViewBag.Category = _context.SubMenus.Where(x => x.Id == id).Select(x => x.Name).ToList();
            return View(category);
        }
    }
}