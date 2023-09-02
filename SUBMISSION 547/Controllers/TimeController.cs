using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUBMISSION_547.Controllers
{
    public class TimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Time()
        {
            return View("Data");
        }





    }
}
