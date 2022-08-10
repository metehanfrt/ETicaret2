using AspNetMvcAds.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly AppDatabaseContext _db;

        public NavbarViewComponent(AppDatabaseContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _db.Categories.ToListAsync();

            return View(categories);
        }
    }
}
