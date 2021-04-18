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
    public class OrderController : Controller
    {
        private readonly CarDbContext db;

        public OrderController(CarDbContext context)
        {
            db = context;
        }

        [Route("[controller]")]
        [Route("[controller]/index")]

        public IActionResult Index()
        {
            List<Order> orders = db.Orders.ToList();
            OrderListVM model = new OrderListVM() { Orders = orders };
            return View(model);
        }

        [Route("commande")]
        [Route("commande/{*voiture}")]
        [Route("commande/{voiture?}")]
        public IActionResult Order(string voiture)
        {
            if(voiture != null)
            {
                CreateOrderVM model = new CreateOrderVM()
                {
                    CarName = voiture,
                    ClientName = "",
                    Telephone = ""
                };
                return View(model);
            }

            return View();
        }

        public IActionResult CreateOrder(CreateOrderVM order)
        {
            Order orderDb = new Order() { OrderId = 0, Date = DateTime.Now, ClientName = order.ClientName, CarName = order.CarName, Telephone = order.Telephone };
            db.Orders.Add(orderDb);
            db.SaveChanges();

            CarListVM model = new CarListVM() { cars = db.Cars.ToList() };
            return View("/Views/Car/Index.cshtml", model);
        }

        [Route("commande/supprime/{*id}")]
        [Route("commande/supprime/{id?}")]
        public IActionResult RemoveOrder(int id) 
        {
            List<Order> orders = db.Orders.ToList();
            foreach(Order o in orders)
            {
                if(o.OrderId == id)
                {
                    db.Orders.Remove(o);
                }
            }
            db.SaveChanges();

            List<Order> orders2 = db.Orders.ToList();
            OrderListVM model = new OrderListVM() { Orders = orders2 };
            return View("Index", model);
        }

        [Route("commande/modif/{*id}")]
        [Route("commande/modif/{id?}")]
        public IActionResult EditOrder(int id)
        {
            List<Order> orders = db.Orders.ToList();
            EditOrderVM model = new EditOrderVM();
            foreach (Order o in orders)
            {
                if (o.OrderId == id)
                {
                    model = new EditOrderVM() { CarName = o.CarName, ClientName = o.ClientName, Telephone = o.Telephone, OrderId = id };
                }
            }


            return View("Edit",model);
        }

        public IActionResult EditOrderFinal(EditOrderVM order)
        {
            List<Order> orders = db.Orders.ToList();
            Order newOrder = new Order() { OrderId = order.OrderId, CarName = order.CarName, ClientName = order.ClientName, Telephone = order.Telephone};
            foreach(Order o in orders)
            {
                if(o.OrderId == order.OrderId)
                {
                    db.Entry(o).CurrentValues.SetValues(newOrder);
                }
            }
            db.SaveChanges();

            List<Order> orders2 = db.Orders.ToList();
            OrderListVM model = new OrderListVM() { Orders = orders2 };
            return View("Index", model);
        }


    }
}
