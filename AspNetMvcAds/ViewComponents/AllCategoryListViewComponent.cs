using AspNetMvcAds.Data;
using AspNetMvcAds.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.ViewComponents
{
    public class AllCategoryListViewComponent : ViewComponent
    {
        private readonly AppDatabaseContext _db;

        public AllCategoryListViewComponent(AppDatabaseContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var allCategories = await _db.Categories.ToListAsync();

            var advertCategories = _db.Adverts
                .Include(e => e.Categories)
                .Select(e => new AdvertCategoryStatisticModel
                {
                    AdvertId = e.Id,
                    CategoryId = e.Categories.FirstOrDefault() != null
                        ? e.Categories.FirstOrDefault().Id
                        : 0,
                })
                .ToList();

            var model = new CategoryViewModel
            {
                AllCategories = allCategories,
                AllAdvertCategories = advertCategories,
            };

            return View(model);
        }
    }
}
