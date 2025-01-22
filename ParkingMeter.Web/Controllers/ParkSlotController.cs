using Microsoft.AspNetCore.Mvc;
using ParkingMeter.Business.Abstract;
using ParkingMeter.Models;

namespace ParkingMeter.Web.Controllers
{
    public class ParkSlotController : Controller
    {
        private readonly IParkSlotService _parkSlotService;

        public ParkSlotController (IParkSlotService parkSlotService)
        {
            _parkSlotService = parkSlotService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _parkSlotService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(ParkSlot parkSlot)
        {
            return Ok(_parkSlotService.Add(parkSlot));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_parkSlotService.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(ParkSlot parkSlot)
        {
            return Ok(_parkSlotService.Update(parkSlot));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _parkSlotService.Delete(id);
            return Ok();
        }

        public IActionResult GetFreeParkSlots()
        {
            return Json(new { data = _parkSlotService.GetFreeParkSlots() });
        }
    }
}
