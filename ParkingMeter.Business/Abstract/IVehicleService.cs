using ParkingMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Abstract
{
    public interface IVehicleService
    {
        Vehicle Add(Vehicle vehicle);
        Vehicle Update(Vehicle vehicle);
        bool Delete(int vehicleId);
        IQueryable<Vehicle> GetAll();
        Vehicle GetById(int vehicleId);
    }
}
