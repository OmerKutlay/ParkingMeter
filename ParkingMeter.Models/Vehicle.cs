﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Models
{
    public class Vehicle : BaseModel
    {
        public string Plate { get; set; }
        public string VehicleType { get; set; } = "Otomobil";
        public string? ContactNumber { get; set; }
        public bool IsSubscribed { get; set; } = false;
        public DateTime EntryTime { get; set; } = DateTime.Now;
        public DateTime? ExitTime { get; set; }
        public int ParkSlotId { get; set; }
        public virtual ParkSlot? ParkSlot { get; set; }
        [ForeignKey("Payment")]
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Parking> Parkings { get; set; }

    }
}
