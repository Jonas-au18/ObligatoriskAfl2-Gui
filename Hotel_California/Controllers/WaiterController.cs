using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_California.Controllers
{
    public class WaiterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WaiterView()
        {
            return View();
        }
    }
}