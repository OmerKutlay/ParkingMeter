using ParkingMeter.Business.Abstract;
using ParkingMeter.Models;
using ParkingMeter.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Concrete
{
    public class ParkSlotService : IParkSlotService
    {
        private readonly IRepository<ParkSlot> _parkSlotRepository;

        public ParkSlotService(IRepository<ParkSlot> parkSlotRepository)
        {
            _parkSlotRepository = parkSlotRepository;
        }
        public ParkSlot Add(ParkSlot ParkSlot)
        {
            return _parkSlotRepository.Add(ParkSlot);
        }

        public bool Delete(int ParkSlotId)
        {
            _parkSlotRepository.Delete(ParkSlotId);
            return true;
        }

        public IQueryable<ParkSlot> GetAll()
        {
            return _parkSlotRepository.GetAll();
        }

        public ParkSlot GetById(int id)
        {
            return _parkSlotRepository.GetById(id);
        }

        public IQueryable<ParkSlot> GetFreeParkSlots()
        {
            return _parkSlotRepository.GetAll(ps => ps.IsDeleted == false).Where(ps => ps.IsOccupied == false);
        }

        public ParkSlot Update(ParkSlot ParkSlot)
        {
          return _parkSlotRepository.Update(ParkSlot);
        }
    }
}
