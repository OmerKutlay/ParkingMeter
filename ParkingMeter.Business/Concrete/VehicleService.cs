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
    public class VehicleService: IVehicleService
    {
        private readonly IRepository<Vehicle> _vehicleRepository;

        public VehicleService(IRepository<Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Vehicle Add(Vehicle vehicle)
        {
            return _vehicleRepository.Add(vehicle);
        }

        public bool Delete(int vehicleId)
        {
            _vehicleRepository.Delete(vehicleId);
            return true;
        }

        public IQueryable<Vehicle> GetAll()
        {
            return _vehicleRepository.GetAll(v => v.IsDeleted == false);
        }

        public Vehicle GetById(int vehicleId)
        {
            return _vehicleRepository.GetById(vehicleId);
        }

        public Vehicle Update(Vehicle vehicle)
        {
            return _vehicleRepository.Update(vehicle);
        }
    }
}
