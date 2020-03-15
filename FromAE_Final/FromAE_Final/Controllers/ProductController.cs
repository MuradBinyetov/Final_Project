using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAE_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace FromAE_Final.Controllers
{
    public class ProductController : Controller
    {
        private readonly FromAeDbContext _context;
        public ProductController(FromAeDbContext context)
        {
            _context = context;
        }
        public IActionResult GetProduct(int id)
        {
            ViewBag.Prop = _context.ProductProperties.Where(x => x.ProductId == id).Select(y=>y.Property.Name).ToList();
            ViewBag.PropValue = _context.ProductProperties.Where(x => x.ProductId == id).Select(y=>y.Value).ToList();
            ViewBag.Img = _context.Products.Where(x => x.Id == id).Select(y=>y.MainImg).ToList();
            ViewBag.Name = _context.Products.Where(x => x.Id == id).Select(y=>y.Name).ToList();
            ViewBag.Price = _context.Products.Where(x => x.Id == id).Select(y=>y.Price).ToList();
            return View();
        }


        public IActionResult Filter(int id)
        {

            ViewBag.Name = _context.ProductCategories.Where(x => x.CategoryId == id).Select(y => y.Category.Name).ToList();
            ViewModel viewModel = new ViewModel();
            viewModel.categories = _context.Categories.ToList();
            viewModel.products = _context.Products.ToList();
            viewModel.productCategories = _context.ProductCategories.ToList();
            var prod= _context.Products.Where(x => x.ProductCategories.Any(y => y.CategoryId == id));
            return View(prod);
        }
    }
}