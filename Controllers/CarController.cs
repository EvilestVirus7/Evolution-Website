using EvoWebsite.Data;
using EvoWebsite.Models;
using EvoWebsite.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        [Route("[controller]")]
        [Route("[controller]/index")]
        [Route("[controller]/index/{*search}")]
        [Route("[controller]/index/{search?}")]
        public IActionResult Index(string search)
        {
            
            List<Car> cars = db.Cars.ToList();
            List<Car> searchCars = new List<Car>();
            if (search != null)
            {
                foreach(Car c in cars)
                {
                    var input = c.Name;
                    var output1 = Regex.Replace(input.Split()[0], @"[^0-9a-zA-Z\ ]+", "");

                    if (c.Name.ToLower().Trim() == search.ToLower().Trim())
                    {
                        searchCars.Add(c);
                    }else if(output1.Trim().ToLower() == search.ToLower().Trim())
                    {
                        searchCars.Add(c);
                    }

                }

                    CarListVM model2 = new CarListVM() { cars = searchCars };
                    return View(model2);

            }
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

        public IActionResult SUVs()
        {
            List<Car> suvs = db.Cars.Where(e => e.Type == "SUV").ToList();
            CarListVM model = new CarListVM() { cars = suvs };
            return View(model);
        }

        public IActionResult Muscles()
        {
            List<Car> muscles = db.Cars.Where(e => e.Type == "Muscle").ToList();
            CarListVM model = new CarListVM() { cars = muscles };
            return View(model);
        }

        public IActionResult Coupes()
        {
            List<Car> coupes = db.Cars.Where(e => e.Type == "Coupe").ToList();
            CarListVM model = new CarListVM() { cars = coupes };
            return View(model);
        }

        public IActionResult Compacts()
        {
            List<Car> compacts = db.Cars.Where(e => e.Type == "Compact").ToList();
            CarListVM model = new CarListVM() { cars = compacts };
            return View(model);
        }

        public IActionResult Vans()
        {
            List<Car> vans = db.Cars.Where(e => e.Type == "Van").ToList();
            CarListVM model = new CarListVM() { cars = vans };
            return View(model);
        }

        public IActionResult Offroad()
        {
            List<Car> offroads = db.Cars.Where(e => e.Type == "Offroad").ToList();
            CarListVM model = new CarListVM() { cars = offroads };
            return View(model);
        }
        public IActionResult Motos()
        {
            List<Car> motos = db.Cars.Where(e => e.Type == "Moto").ToList();
            CarListVM model = new CarListVM() { cars = motos };
            return View(model);
        }
    }
}


