using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FromAE_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace FromAE_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FromAeDbContext context;

        public HomeController(ILogger<HomeController> logger, FromAeDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

      
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.categories = context.Categories.ToList();
            viewModel.products = context.Products.ToList();
            viewModel.comments = context.Comments.ToList();
            viewModel.pictures = context.Pictures.ToList();
            viewModel.markas = context.Markas.ToList();
            viewModel.models = context.Models.ToList();
            viewModel.menus = context.Menus.ToList();
            viewModel.subMenus = context.SubMenus.ToList();
            viewModel.ratings = context.Ratings.ToList();
            viewModel.properties = context.Properties.ToList();
            viewModel.productProperties = context.ProductProperties.ToList();
            viewModel.productCategories = context.ProductCategories.ToList();
            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult FooterDelivery()
        {
            return View();
        }
        public IActionResult FooterPayment()
        {
            return View();
        }

        public IActionResult FooterSendRules()
        {
            return View();
        }
        public IActionResult FooterSecurity()
        {
            return View();
        }
        public IActionResult FooterService()
        {
            return View();
        }
        public IActionResult FooterOrder()
        {
            return View();
        }
        public IActionResult FooterAnswerQuestion()
        {
            return View();
        }
    }
}
