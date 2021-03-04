using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using a.Models;

namespace a.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<a.Models.Client> Client { get; set; }
        public DbSet<a.Models.Location> Location { get; set; }
        public DbSet<a.Models.Timeslot> Timeslot { get; set; }
        public DbSet<a.Models.Vaccine> Vaccine { get; set; }
        public DbSet<a.Models.Appointment> Appointment { get; set; }
        public DbSet<a.Models.Booking> Booking { get; set; }
    }
}
