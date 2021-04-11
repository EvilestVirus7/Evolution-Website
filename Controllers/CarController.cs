using EvoWebsite.Data;
using EvoWebsite.Models;
using EvoWebsite.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Controllers
{
    public class CarController : Controller
    {
        private readonly CarDbContext db;

        public CarController(CarDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            List<Car> cars = db.Cars.ToList();
            CarListVM model = new CarListVM() { cars = cars };
            return View(model);
        }

        public IActionResult Supers()
        {
            List<Car> supers = db.Cars.Where(e => e.Type == "Super").ToList();
            CarListVM model = new CarListVM() { cars = supers };
            return View(model);
        }

        public IActionResult Sports()
        {
            List<Car> sports = db.Cars.Where(e => e.Type == "Sport").ToList();
            CarListVM model = new CarListVM() { cars = sports };
            return View(model);
        }

        public IActionResult SportsClassics()
        {
            List<Car> sportclassics = db.Cars.Where(e => e.Type == "SportClassics").ToList();
            CarListVM model = new CarListVM() { cars = sportclassics };
            return View(model);
        }

        public IActionResult Sedans()
        {
            List<Car> sedans = db.Cars.Where(e => e.Type == "Sedans").ToList();
            CarListVM model = new CarListVM() { cars = sedans };
            return View(model);
        }

        
    }
}
