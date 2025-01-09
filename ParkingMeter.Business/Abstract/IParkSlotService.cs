using ParkingMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Abstract
{
    public interface IParkSlotService
    {
        ParkSlot Add(ParkSlot ParkSlot);
        ParkSlot Update(ParkSlot ParkSlot);
        ParkSlot GetById(int id);
        bool Delete(int ParkSlotId);
        IQueryable<ParkSlot> GetAll();
        IQueryable<ParkSlot> GetFreeParkSlots();
    }
}
