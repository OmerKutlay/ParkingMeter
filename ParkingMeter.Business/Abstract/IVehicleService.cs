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
        Vehicle Add(Vehicle vehicle, List<Payment> payments);
        Vehicle Update(Vehicle vehicle, List<Payment> payments);
        bool Delete(int vehicleId);
        IQueryable<Vehicle> GetAll();
        Vehicle GetById(int vehicleId);
    }
}
