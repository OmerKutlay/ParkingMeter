using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Models
{
    public class Payment:BaseModel
    {
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }= false;
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
