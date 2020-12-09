using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Participation4.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello World!");
            return View();
        }
        public IActionResult MNHello()
        {
            //return Content("Hello World!");
            return View();
        }

        public IActionResult WIHello()
        {
            //return Content("Hello World!");
            return View();
        }
    }
}
