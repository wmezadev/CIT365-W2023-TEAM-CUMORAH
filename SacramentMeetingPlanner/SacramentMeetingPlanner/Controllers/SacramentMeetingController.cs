using Microsoft.AspNetCore.Mvc;

namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
