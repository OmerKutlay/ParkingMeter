using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Models
{
    public class ParkSlot : BaseModel
    {
        public string Row { get; set; }
        public string Column { get; set; }
        public bool IsOccupied { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<Parking> Parkings { get; set; }
    }
}
