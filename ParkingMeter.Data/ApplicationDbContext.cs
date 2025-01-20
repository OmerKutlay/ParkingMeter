using Microsoft.EntityFrameworkCore;
using ParkingMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public virtual DbSet<ParkSlot> ParkSlots { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }
    }
}
