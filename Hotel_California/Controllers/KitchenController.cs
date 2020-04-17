using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_California.Data;
using Hotel_California.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel_California.Controllers
{
    public class KitchenController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KitchenView()
        {
            return View();
        }
    }
}