using Microsoft.EntityFrameworkCore;
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
        private readonly IRepository<ParkSlot> _parkSlotRepository;
        public VehicleService(IRepository<Vehicle> vehicleRepository, IRepository<ParkSlot> parkSlotRepository)
        {
            _vehicleRepository = vehicleRepository;
            _parkSlotRepository = parkSlotRepository;
        }

        public Vehicle Add(Vehicle vehicle, List<Payment> payments)
        {
            _vehicleRepository.Add(vehicle);
            foreach (var item in payments)
            {
                item.VehicleId = vehicle.Id;
            }
            vehicle.Payments = payments;

            var ParkSlot = _parkSlotRepository.GetById(vehicle.ParkSlotId);
            if (ParkSlot != null)
            {
                ParkSlot.IsOccupied = true;
                _parkSlotRepository.Update(ParkSlot);
            }

            _vehicleRepository.Update(vehicle);
            return vehicle;
        }

        public bool Delete(int vehicleId)
        {
           var vehicle = _vehicleRepository.GetById(vehicleId);

            _vehicleRepository.Delete(vehicleId);

            var VehicleOnParkSlot = _vehicleRepository.GetAll(ve => ve.ParkSlotId == vehicle.ParkSlotId && !ve.IsDeleted).Any();

            if (!VehicleOnParkSlot)
            {
                var parkSlot = _parkSlotRepository.GetById(vehicle.ParkSlotId);
                if (parkSlot != null) {
                    parkSlot.IsOccupied = false;
                    _parkSlotRepository.Update(parkSlot); 
                }
            }
            return true;
        }

        public IQueryable<Vehicle> GetAll()
        {
            var result = _vehicleRepository.GetAll().Where(ve => !ve.IsDeleted).Select(ve => new Vehicle
            {
                Name = ve.Name,
                Id = ve.Id,
                Plate = ve.Plate,
                VehicleType = ve.VehicleType,
                Amount = ve.Amount,
                ContactNumber = ve.ContactNumber,
                IsSubscribed = ve.IsSubscribed,
                ExitTime = ve.ExitTime,
                ParkSlotId = ve.ParkSlotId,
                Payments = ve.Payments,
            });
            return result;
        }

        public Vehicle GetById(int vehicleId)
        {
            return _vehicleRepository.GetAll(ve => ve.Id == vehicleId).FirstOrDefault();
        }

        // BU KISIM HATALI ÇALIŞIYOR OLABİLİR!!!
        public Vehicle Update(Vehicle vehicle, List<Payment> payments)
        {
            vehicle.Payments = new List<Payment>();
            _vehicleRepository.Update(vehicle);

            vehicle.Payments = payments;
            return _vehicleRepository.Update(vehicle);
        }
    }
}
