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
    public class CarlistController : Controller
    {
        private readonly CarDbContext db;

        public CarlistController(CarDbContext context)
        {
            db = context;
        }

        [Route("[controller]")]
        [Route("[controller]/index")]

        public IActionResult Index()
        {
            List<Car> cars = db.Cars.ToList();
            CarListVM model = new CarListVM() { cars = cars };
            return View(model);
        }

        

        [Route("voiture/supprime/{*id}")]
        [Route("voiture/supprime/{id?}")]
        public IActionResult RemoveCar(int id) 
        {
            List<Car> cars = db.Cars.ToList();
            foreach(Car c in cars)
            {
                if(c.CarId == id)
                {
                    db.Cars.Remove(c);
                }
            }
            db.SaveChanges();

            List<Car> cars2 = db.Cars.ToList();
            CarListVM model = new CarListVM() { cars = cars2 };
            return View("Index", model);
        }

        [Route("voiture/modif/{*id}")]
        [Route("voiture/modif/{id?}")]
        public IActionResult EditCar(int id)
        {
            List<Car> cars = db.Cars.ToList();
            EditCarVM model = new EditCarVM();
            foreach (Car c in cars)
            {
                if (c.CarId == id)
                {
                    model = new EditCarVM() {CarId = id, ImgPath = c.ImgPath, MSRP = c.MSRP, Name = c.Name, Price = c.Price, Type = c.Type};
                }
            }


            return View("Edit",model);
        }

        public IActionResult EditCarFinal(EditCarVM car)
        {
            List<Car> cars = db.Cars.ToList();
            Car newCar = new Car() { CarId = car.CarId, Type = car.Type, Price = car.Price, Name = car.Name, MSRP = car.MSRP, ImgPath = car.ImgPath};
            foreach(Car c in cars)
            {
                if(c.CarId == car.CarId)
                {
                    db.Entry(c).CurrentValues.SetValues(newCar);
                }
            }
            db.SaveChanges();

            List<Car> cars2 = db.Cars.ToList();
            CarListVM model = new CarListVM() { cars = cars2 };
            return View("Index", model);
        }


    }
}
