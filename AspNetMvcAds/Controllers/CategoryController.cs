using AspNetMvcAds.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDatabaseContext db;
        public CategoryController(AppDatabaseContext db)
        {
            this.db = db;
        }

        public IActionResult Index(int cid)
        {
            var adverts = db.Adverts
                .Include(e => e.User)
                .Include(e => e.AdvertComments).ThenInclude(e => e.User)
                .Include(e => e.AdvertImages)
                .Include(e => e.Categories)
                .Where(e => e.Categories.Any(c => c.Id == cid));

            ViewBag.Category = db.Categories.FirstOrDefault(e => e.Id == cid);

            return View(adverts.ToList());
        }
    }
}
