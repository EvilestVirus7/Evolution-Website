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

        public IActionResult Index()
        {
            List<Order> orders = db.Orders.ToList();
            OrderListVM model = new OrderListVM() { Orders = orders };
            return View(model);
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult CreateOrder(CreateOrderVM order)
        {
            Order orderDb = new Order() { OrderId = 0, Date = DateTime.Now, ClientName = order.ClientName, CarName = order.CarName, Telephone = order.Telephone };
            db.Orders.Add(orderDb);
            db.SaveChanges();
            return View("Order");
        }

        
    }
}
