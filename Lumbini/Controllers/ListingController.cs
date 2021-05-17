using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumbini.Controllers
{
    public class ListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
