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
        [ForeignKey("Vehicle")]
        public int? VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}
