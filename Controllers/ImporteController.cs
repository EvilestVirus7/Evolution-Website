using EvoWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Controllers
{
    public class ImporteController : Controller
    {
        private readonly CarDbContext db;

        public ImporteController(CarDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
