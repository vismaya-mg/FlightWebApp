using FlightWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlightWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
       
       
            private readonly ApplicationDbContext db;

            public HomeController(ApplicationDbContext db)
            {
                this.db = db;
            }

            public IActionResult Index()
            {
                return View(db.Flights.ToList());

            }

            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Register(FlightViewModel model)
            {
                if (!ModelState.IsValid)
                    return View();
            db.Flights.Add(new Flight()
            {
                Flight_name = model.Flight_name,
                Flight_descriptiom = model.Flight_descriptiom,
                flight_total_capacity=model.flight_total_capacity,
                Flight_Type=model.Flight_Type

            });
                await db.SaveChangesAsync();
                return RedirectToAction("index", "home", "flights");
            }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var flight = await db.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(new FlightViewModel()
            {
                Flight_name = flight.Flight_name,
                Flight_Type = flight.Flight_Type,
                Flight_descriptiom = flight.Flight_descriptiom,
                flight_total_capacity = flight.flight_total_capacity
            });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int FlightId, FlightViewModel model)
        {
            var flight = await db.Flights.FindAsync(FlightId);
            if (flight == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
              
           model.Flight_name = flight.Flight_name;
            model.Flight_descriptiom=flight.Flight_descriptiom;
            model.Flight_Type=flight.Flight_Type;
            model.flight_total_capacity = flight.flight_total_capacity;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //public async Task<IActionResult> Delete(long id)
        //{
        //    var flight = await db.Flights.FindAsync(id);
        //    if (flight == null)
        //    {
        //        return NotFound();
        //    }
        //    db.Flights.Remove(flight);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}



    }
}
