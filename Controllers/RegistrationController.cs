using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop_Lab18.Controllers
{
    public class RegistrationController : Controller
    {
        
        [HttpGet]//means were getting info
        public IActionResult Index()
        {
            return View(new Registration());
        }
        [HttpPost]//means we are posting info to our server
        public IActionResult Index(Registration newRegistration)
        {
            return RedirectToAction("Welcome", newRegistration);
        }
        public IActionResult Welcome(Registration registration)
        {
            return View(registration);
        }
    }
}