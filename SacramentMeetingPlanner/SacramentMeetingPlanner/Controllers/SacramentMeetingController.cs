using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SacramentMeetingPlanner.Controllers;

public class SacramentMeetingController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

