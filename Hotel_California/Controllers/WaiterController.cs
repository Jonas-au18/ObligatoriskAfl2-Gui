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
    public class WaiterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WaiterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Guest> GetGuests()
        {
            return _context.Guest;
        }

        [HttpGet]
        public IEnumerable<Room> GetRooms()
        {
            return _context.Room;
        }

        // GET: api/Waiter/allGuests
        [HttpGet("allGuests")]
        public async Task<ActionResult<List<Guest>>> GetAllGuests()
        {
            var allguests = await _context.Guest
                .OrderBy(guest => guest.GuestID)
                .ToListAsync();
            return allguests;
        }

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