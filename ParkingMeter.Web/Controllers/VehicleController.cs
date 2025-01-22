using Microsoft.AspNetCore.Mvc;
using ParkingMeter.Business.Abstract;
using ParkingMeter.Models;

namespace ParkingMeter.Web.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _vehicleService.GetAll() });

        }

        [HttpPost]
        public IActionResult Add(Vehicle vehicle, List<Payment> payments)
        {
            return Ok(_vehicleService.Add(vehicle, payments));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            var vehicle = _vehicleService.GetById(id);

            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Update(Vehicle vehicle, List<Payment> payments)
        {
            return Ok(_vehicleService.Update(vehicle, payments));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_vehicleService.Delete(id));
        }
    }
}
