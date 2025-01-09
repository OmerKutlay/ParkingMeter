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
            throw new NotImplementedException();
        }

        public bool Delete(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Vehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Vehicle Update(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
