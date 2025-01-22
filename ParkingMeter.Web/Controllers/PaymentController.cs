using Microsoft.AspNetCore.Mvc;
using ParkingMeter.Business.Abstract;
using ParkingMeter.Models;

namespace ParkingMeter.Web.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController ( IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _paymentService.GetAll() });
        }

        [HttpGet]
        public IActionResult GetAllByVehicleId(int vehicleId)
        {
            return Ok(new { data = _paymentService.GetAllByVehicleId(vehicleId) });
        }

        [HttpPost]
        public IActionResult Add(Payment payment)
        {
            return Ok(_paymentService.Add(payment));
        }

        [HttpPost]
        public IActionResult Update(Payment payment)
        {
            return Ok(_paymentService.Update(payment));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _paymentService.Delete(id);
            return Ok();
        }
    }   
}
