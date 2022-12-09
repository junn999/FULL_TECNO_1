using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FULL_TECNO_1.Controllers
{
    public class AudifonosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
