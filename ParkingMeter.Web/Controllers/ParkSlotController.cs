using Microsoft.AspNetCore.Mvc;

namespace ParkingMeter.Web.Controllers
{
    public class ParkSlotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
