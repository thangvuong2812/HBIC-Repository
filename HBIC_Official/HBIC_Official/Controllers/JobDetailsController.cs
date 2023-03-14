using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Controllers
{
    public class JobDetailsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.IsLogin = TempData["isLogin"];
            return View();
        }
    }
}
