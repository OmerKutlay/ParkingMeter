using ParkingMeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMeter.Business.Abstract
{
    public interface IPaymentService
    {
        Payment Add (Payment payment);
        Payment Update (Payment payment);
        Payment GetById (int id);
        List<Payment> GetAllByVehicleId (int vehicleId);
        bool Delete(int PaymentId);
        IQueryable<Payment> GetAll();

    }
}
