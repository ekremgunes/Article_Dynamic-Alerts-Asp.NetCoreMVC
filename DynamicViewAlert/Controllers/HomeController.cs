using DynamicViewAlert.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewAlertApp.Extensions;

namespace DynamicViewAlert.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["alerts"] = this.ViewAlert(AlertType.Success,"gunesekrem.com success");
            
            TempData["alerts"] += this.ViewAlert(AlertType.Info,"info message");
            
            TempData["alerts"] += this.ViewAlert(AlertType.Warning,"warnin message");
            
            TempData["alerts"] += this.ViewAlert(AlertType.Error,"error message");

            //gunesekrem.com
            
            return View();
        }

    }
}