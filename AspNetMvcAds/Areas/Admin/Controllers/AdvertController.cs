#nullable disable

using AspNetMvcAds.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertController : Controller
    {
        private readonly AppDatabaseContext _context;

        public AdvertController(AppDatabaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Advert
        public async Task<IActionResult> Index()
        {
            var appDatabaseContext = _context.Adverts.Include(a => a.User);
            return View(await appDatabaseContext.ToListAsync());
        }

        // GET: Admin/Advert/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advert == null)
            {
                return NotFound();
            }

            return View(advert);
        }

        // GET: Admin/Advert/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Admin/Advert/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Title,SubTitle,Description,Price,Location")] Advert advert)
        {
            if (ModelState.IsValid)
            {
                advert.CreatedAt = DateTime.Now;
                //advert.ViewCount = 0;

                _context.Add(advert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", advert.UserId);
            return View(advert);
        }

        // GET: Admin/Advert/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts.FindAsync(id);
            if (advert == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", advert.UserId);
            return View(advert);
        }

        // POST: Admin/Advert/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Title,SubTitle,Description,Price,Location")] Advert advert)
        {
            if (id != advert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    advert.UpdateAt = DateTime.Now;

                    _context.Update(advert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvertExists(advert.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", advert.UserId);
            return View(advert);
        }

        // GET: Admin/Advert/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advert == null)
            {
                return NotFound();
            }

            return View(advert);
        }

        // POST: Admin/Advert/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advert = await _context.Adverts.FindAsync(id);
            _context.Adverts.Remove(advert);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvertExists(int id)
        {
            return _context.Adverts.Any(e => e.Id == id);
        }
    }
}