using System;
using System.Collections.Generic;
using System.Text;
using Hotel_California.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel_California.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        { }

        public ApplicationDbContext()
        { }


        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }

    }
    
}

