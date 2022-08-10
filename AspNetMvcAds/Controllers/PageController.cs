using AspNetMvcAds.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcAds.Controllers
{
    public class PageController : Controller
    {
        private readonly AppDatabaseContext db;
        public PageController(AppDatabaseContext db)
        {
            this.db = db;
        }

        public IActionResult Detail(int id)
        {
            var page = db.Pages.FirstOrDefault(x => x.Id == id);

            return View(page);
        }
    }
}
