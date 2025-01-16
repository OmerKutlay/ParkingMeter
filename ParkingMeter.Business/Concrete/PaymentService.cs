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
    public class PaymentService : IPaymentService
    {
        private readonly IRepository<Payment> _paymentRepository;

        public PaymentService(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment Add(Payment payment)
        {
            return _paymentRepository.Add(payment);
        }

        public bool Delete(int PaymentId)
        {
            _paymentRepository.Delete(PaymentId);
            return true;
        }

        public IQueryable<Payment> GetAll()
        {
           return _paymentRepository.GetAll();
        }

        public List<Payment> GetAllByVehicleId(int vehicleId)
        {
           return _paymentRepository.GetAll(p => p.VehicleId == vehicleId).ToList();
        }

        public Payment GetById(int id)
        {
            return _paymentRepository.GetById(id);
        }

        public Payment Update(Payment payment)
        {
            return _paymentRepository.Update(payment);
        }
    }
}
