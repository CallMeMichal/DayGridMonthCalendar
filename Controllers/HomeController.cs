using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DayGridMonthCalendar.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public async Task<IActionResult> Index()
        {
            int userId = 1;
            var currentDate = DateTime.Now;

            var userAuctions = await _applicationDbContext.Auctions
                .Where(a => a.UserId == userId)
                .Select(a => new
                {
                    title = a.Title,
                    start = a.StartDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                    end = a.EndDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                    color = a.EndDate < currentDate ? "red"
                            : a.StartDate > currentDate ? "gray"
                            : "green",
                    isFavorite = a.IsFavorite
                })
                .ToListAsync();


            var eventsJson = JsonSerializer.Serialize(userAuctions);
            ViewBag.EventsJson = eventsJson;
            return View();
        }
    }
}
