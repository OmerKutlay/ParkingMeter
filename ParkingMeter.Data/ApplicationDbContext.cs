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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ParkSlot>()
        //        .HasOne(ps => ps.Vehicle)
        //        .WithOne(v => v.ParkSlot)
        //        .HasForeignKey<Vehicle>(v => v.ParkSlotId);
        //}


        public virtual DbSet<ParkSlot> ParkSlots { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
