using FromAE_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAE_Final.Components
{
    public class MenuViewComponent : ViewComponent 
    {
        private readonly FromAeDbContext context;
        public MenuViewComponent(FromAeDbContext _context)
        {
            context = _context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu= await context.Menus.Include("SubMenus").ToListAsync();
            return View(menu);
        }
    }
}
