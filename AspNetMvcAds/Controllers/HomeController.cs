using AspNetMvcAds.Data;
using AspNetMvcAds.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AspNetMvcAds.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDatabaseContext db;

        public HomeController(ILogger<HomeController> logger, AppDatabaseContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var trendingAdverts = await db.Adverts
                .Include(e => e.User)
                .Include(e => e.AdvertComments).ThenInclude(e => e.User)
                .Include(e => e.AdvertImages)
                .Include(e => e.Categories)
                .OrderByDescending(e => e.ViewCount)
                .Take(20)
                .ToListAsync();

            var popularCategories = await db.Categories.Where(e => e.IsPopular).ToListAsync();

            var model = new HomePageViewModel
            {
                PopularCategories = popularCategories,
                TrendingAdverts = trendingAdverts
            };

            return View(model);
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
    }
}