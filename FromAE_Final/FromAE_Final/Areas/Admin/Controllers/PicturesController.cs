using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using FromAE_Final.Models;

namespace FromAeFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PicturesController : Controller
    {
        private readonly FromAeDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PicturesController(FromAeDbContext context, IWebHostEnvironment _webHostEnvironment)
        {
            _context = context;
            webHostEnvironment = _webHostEnvironment;
        }


        // GET: Admin/Pictures
        public async Task<IActionResult> Index()
        {
            var fromAeDbContext = _context.Pictures.Include(i => i.Product);
            return View(await fromAeDbContext.ToListAsync());
        }

        // GET: Admin/Pictures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Pictures
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Admin/Pictures/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: Admin/Pictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PictureViewModel image)
        {
            if (ModelState.IsValid)
            {
                Picture newImage;
                foreach(var item in image.Images)
                {
                    newImage = new Picture
                    {
                        Images = UploadedFile(item),
                        ProductId = image.ProductId
                    };
                    _context.Pictures.Add(newImage);
                    await _context.SaveChangesAsync();
                }
               
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", image.ProductId);
            return View(image);
        }

        private string UploadedFile(IFormFile model)
        {
            string uniqueFileName = null;

            if (model != null)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        // GET: Admin/Pictures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Pictures.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", image.ProductId);
            return View(image);
        }

        // POST: Admin/Pictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pictures,ProductId")] Picture image)
        {
            if (id != image.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(image);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageExists(image.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", image.ProductId);
            return View(image);
        }

        // GET: Admin/Pictures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Pictures
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.id == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Admin/Pictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.Pictures.FindAsync(id);
            _context.Pictures.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageExists(int id)
        {
            return _context.Pictures.Any(e => e.id == id);
        }
    }
}
