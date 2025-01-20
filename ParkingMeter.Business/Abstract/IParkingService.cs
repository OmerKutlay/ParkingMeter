using ParkingMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Abstract
{
    public interface IParkingService
    {
        Parking Add(Parking parking);
        Parking Update(Parking parking);
        bool Delete(int parkingId);
        IQueryable<Parking> GetAll();
        Parking GetById(int parkingId);
    }
}
