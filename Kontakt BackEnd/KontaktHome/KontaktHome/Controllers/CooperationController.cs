using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Controllers
{
    public class CooperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
