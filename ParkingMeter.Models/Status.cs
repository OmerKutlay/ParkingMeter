using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Models
{
    public class Status:BaseModel
    {
        public ICollection<ParkSlot> ParkSlots { get; set; }
    }
}
