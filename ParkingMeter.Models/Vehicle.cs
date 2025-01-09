using System;
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
        public int Amount { get; set; } 
        public string? ContactNumber { get; set; }
        public bool IsSubscribed { get; set; } = false;
        public DateTime EntryTime { get; set; } = DateTime.Now;
        public DateTime? ExitTime { get; set; }
        public int? ParkSlotId { get; set; }
        public virtual ParkSlot? ParkSlot { get; set; }
        [ForeignKey("Payment")]
        public int? PaymentId { get; set; }
        public virtual Payment? Payment { get; set; }

    }
}
