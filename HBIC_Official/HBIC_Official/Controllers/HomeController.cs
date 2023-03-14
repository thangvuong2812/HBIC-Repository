using AutoMapper;
using BusinessObject;
using DataAccess.ActionMethod;
using DataAccess.HBICModels;
using HBIC_Official.Code;
using HBIC_Official.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HBICAction hBICAction;
        private IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _mapper = mapper;
            hBICAction = new HBICAction();
            _logger = logger;
        }

        public async Task<IActionResult> Index(BOUserInfo model = null)
        {
            var currentDate = DateTime.Today;
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;
            var listStarupsByCurrentMonthCore = await hBICAction.Select_UsersByMonthAndSubjectId(currentMonth, currentYear, (int)HBIC_Const.Subjects.Startup);
            var listHighlightTop8Core = await hBICAction.Select_UsersTop8ByMonth(currentMonth, currentYear);
            var updatedCoreUsers = await hBICAction.Select_UpdatedUsersTop14();
            var listHighlightTop8 = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(listHighlightTop8Core);
            var listStarupsByCurrentMonth = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(listStarupsByCurrentMonthCore);
            var updatedUsers = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(updatedCoreUsers);
            ViewBag.StartupsMonth = listStarupsByCurrentMonth;
            ViewBag.UpdatedUsers = updatedUsers;
            ViewBag.HighlightTop8 = listHighlightTop8;

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
