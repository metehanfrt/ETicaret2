using AspNetMvcAds.Data;
using AspNetMvcAds.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcAds.Controllers
{
    public class AdvertController : Controller
    {
        private readonly AppDatabaseContext db;
        public AdvertController(AppDatabaseContext db)
        {
            this.db = db;
        }


        public IActionResult Search(string query, string location)
        {
            var adverts = db.Adverts
                .Include(e => e.User)
                .Include(e => e.AdvertComments).ThenInclude(e => e.User)
                .Include(e => e.AdvertImages)
                .Include(e => e.Categories)
                .AsQueryable();

            if (!String.IsNullOrEmpty(query))
            {
                adverts = adverts.Where(e => e.Title.Contains(query) || e.Description.Contains(query));
            }

            if (!String.IsNullOrEmpty(location))
            {
                adverts = adverts.Where(e => location != null && e.Location.Contains(location));
            }

            return View(adverts.ToList());
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) { return NotFound(); }

            var advert = db.Adverts
                .Include(e => e.User)
                .Include(e => e.AdvertComments).ThenInclude(e => e.User)
                .Include(e => e.AdvertImages)
                .Include(e => e.Categories)
                .FirstOrDefault(e => e.Id == id);

            advert.ViewCount = advert.ViewCount + 1;
            db.SaveChanges();

            if (advert == null) { return NotFound(); }

            var vm = new AdvertViewModel()
            {
                Advert = advert,
                AdvertImages = advert.AdvertImages,
                AdvertCategories = advert.Categories,
                AdvertComments = advert.AdvertComments
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult SaveComment(int advertId, string comment, int star)
        {
            //var userName = User.Identity.Name;
            var userName = "Atakan";
            var user = db.Users.FirstOrDefault(e => e.Name == userName);

            var advertComment = new AdvertComment()
            {
                AdvertId = advertId,
                UserId = user.Id,
                Comment = comment,
                CreatedAt = DateTime.Now,
                IsActive = false,
                StarRating = star,
            };

            db.AdvertComments.Add(advertComment);
            db.SaveChanges();

            //return RedirectToAction("Detail", new { Id = advertId });

            return Ok("Yorum kaydedildi");
        }
    }
}
