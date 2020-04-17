using System.Collections.Generic;
using System.Linq;
using Hotel_California.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Hotel_California.Data
{
    public class DbHelper
    {
        public static void SeedData(ApplicationDbContext db, ILogger log)
        {

            Seed(db, log);
        }

        private static void Seed(ApplicationDbContext db, ILogger log)
        {
            var g = db.Guest.FirstOrDefault();
            var r = db.Room.FirstOrDefault();

            var rooms = new List<Room>();
            var room1 = new List<Guest>();
            var room2 = new List<Guest>();
            var room3 = new List<Guest>();
            if (g == null)
            {
                log.LogInformation("Seeding some guest entries.");
                //familiy #1
                g = new Guest()
                {
                    FName = "Hans",
                    LName = "Jensen",
                    Age = 49,
                    GuestID = 1
                };
                room1.Add(g);
                g = new Guest()
                {
                    FName = "Yvonne",
                    LName = "Jensen",
                    Age = 41,
                    GuestID = 2
                };
                room1.Add(g);
                g = new Guest()
                {
                    FName = "Emil",
                    LName = "Jensen",
                    Age = 12,
                    GuestID = 3
                };
                room1.Add(g);
                g = new Guest()
                {
                    FName = "Sarah",
                    LName = "Jensen",
                    Age = 8,
                    GuestID = 4
                };
                room1.Add(g);
                //family #2
                g = new Guest()
                {
                    FName = "Svend",
                    LName = "Stenstrup",
                    Age = 31,
                    GuestID = 5
                };
                room2.Add(g);
                g = new Guest()
                {
                    FName = "Melanie",
                    LName = "Stenstrup",
                    Age = 28,
                    GuestID = 6
                };
                room2.Add(g);
                g = new Guest()
                {
                    FName = "Ditte",
                    LName = "Stenstrup",
                    Age = 4,
                    GuestID = 7
                };
                room2.Add(g);
                g = new Guest()
                {
                    FName = "Jakob",
                    LName = "Stenstrup",
                    Age = 6,
                    GuestID = 8
                };
                room2.Add(g);
                //family #3
                g = new Guest()
                {
                    FName = "Jørgen",
                    LName = "Herrelet",
                    Age = 78,
                    GuestID = 9
                };
                room3.Add(g);
                g = new Guest()
                {
                    FName = "Ingrid",
                    LName = "Herrelet",
                    Age = 72,
                    GuestID = 10
                };
                room3.Add(g);
                db.Guest.AddRange(room1);
                db.Guest.AddRange(room2);
                db.Guest.AddRange(room3);
                db.SaveChangesAsync();
                
            }
            if (r == null)
            {
                log.LogInformation("Seeding some room entries.");
                //Room #1
                r = new Room()
                {
                    RoomNr = 1,
                    Guest = room1,
                    Occupied = true
                };
                rooms.Add(r);
                //Room #2
                r = new Room()
                {
                    RoomNr = 2,
                    Guest = room2,
                    Occupied = true
                };
                rooms.Add(r);
                //Room #3
                r = new Room()
                {
                    RoomNr = 3,
                    Guest = room3,
                    Occupied = true
                };
                rooms.Add(r);
                //Room #4
                r = new Room()
                {
                    RoomNr = 4,
                    Guest = null,
                    Occupied = false
                };
                rooms.Add(r);
                //Room #5
                r = new Room()
                {
                    RoomNr = 5,
                    Guest = null,
                    Occupied = false
                };
                rooms.Add(r);
                db.Room.AddRange(rooms);
                db.SaveChangesAsync();
            }
        }
    }
}
