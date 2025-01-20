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
    public class ParkingService : IParkingService
    {
        private readonly IRepository<Parking> _parkingRepository;

        public ParkingService(IRepository<Parking> parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        public Parking Add(Parking parking)
        {
            return _parkingRepository.Add(parking);
        }

        public bool Delete(int parkingId)
        {
            _parkingRepository.Delete(parkingId);
            return true;
        }

        public IQueryable<Parking> GetAll()
        {
            return _parkingRepository.GetAll();
        }

        public Parking GetById(int parkingId)
        {
            return _parkingRepository.GetById(parkingId);
        }

        public Parking Update(Parking parking)
        {
            return _parkingRepository.Update(parking);
        }
    }
}
