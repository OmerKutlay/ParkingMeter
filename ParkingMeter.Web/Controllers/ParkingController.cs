using Microsoft.AspNetCore.Mvc;
using ParkingMeter.Business.Abstract;
using ParkingMeter.Models;

namespace ParkingMeter.Web.Controllers
{
    public class ParkingController : Controller
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingServive)
        {
            _parkingService = parkingServive;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _parkingService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(Parking parking)
        {
            return Ok(_parkingService.Add(parking));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            var parking = _parkingService.GetById(id);

            return Ok(parking);
        }

        [HttpPost]
        public IActionResult Update(Parking parking)
        {
            return Ok(_parkingService.Update(parking));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_parkingService.Delete(id));
        }

    }
}
