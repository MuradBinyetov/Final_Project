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

        public IActionResult GetCategoryProp(int id)
        {
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
            ViewBag.Istehsalci = (from m in _context.Markas
                                  join mo in _context.Models on m.Id equals mo.MarkaId
                                  join p in _context.Products on mo.Id equals p.ModelId
                                  join pc in _context.ProductCategories on p.Id equals pc.ProductId
                                  join c in _context.Categories on pc.CategoryId equals c.Id
                                  where c.Id == id
                                  select m.Name).Distinct();

            ViewBag.Filter = (from C in _context.Categories
                              join PC in _context.ProductCategories
                              on C.Id equals PC.CategoryId
                              join P in _context.Products
                              on PC.ProductId equals P.Id
                              join PP in _context.ProductProperties
                              on P.Id equals PP.ProductId
                              join PR in _context.Properties
                              on PP.PropertyId equals PR.Id
                              where C.Id == id
                              select PR.Name).Distinct();
           
            return View(prod);
        }
    }
}