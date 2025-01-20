using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Models
{
    public class Parking:BaseModel
    {
        public int ParkSlotId { get; set; }
        public virtual ParkSlot ParkSlot { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<Payment> Payments { get; set; }= new List<Payment>();
    }
}
