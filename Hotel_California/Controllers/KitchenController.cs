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
        private readonly ApplicationDbContext _context;

        public KitchenController(ApplicationDbContext context)
        {
            _context = context;
        }

        ////public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> KitchenView()
        {
            return PartialView(await _context.Guest.ToListAsync());
        }
    }
}