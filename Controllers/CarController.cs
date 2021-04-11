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
    }
}
