using Microsoft.AspNetCore.Mvc;
using MvcCoreModelValidation_Demo.Models;

namespace MvcCoreModelValidation_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

    }
}
