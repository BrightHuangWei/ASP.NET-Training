using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHotelReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //成人数量
            List<SelectListItem> adultsItemList = new List<SelectListItem>
            {
                new SelectListItem { Text = "0", Value = "0", Selected = false },
                new SelectListItem { Text = "1", Value = "1", Selected = false },
                new SelectListItem { Text = "2", Value = "2", Selected = false },
                new SelectListItem { Text = "3", Value = "3", Selected = false },
                new SelectListItem { Text = "4", Value = "4", Selected = false },
                new SelectListItem { Text = "5", Value = "5", Selected = false }
            };
            ViewData["numAdults"] = adultsItemList;
            //小孩数量
            List<SelectListItem> childItemList = new List<SelectListItem>
            {
                new SelectListItem { Text = "0", Value = "0", Selected = false },
                new SelectListItem { Text = "1", Value = "1", Selected = false },
                new SelectListItem { Text = "2", Value = "2", Selected = false },
                new SelectListItem { Text = "3", Value = "3", Selected = false },
                new SelectListItem { Text = "4", Value = "4", Selected = false },
                new SelectListItem { Text = "5", Value = "5", Selected = false }
            };
            ViewData["numChlid"] = childItemList;
            //套房类型
            List<SelectListItem> suiteItemList = new List<SelectListItem>
            {
                new SelectListItem { Text = "单人间", Value = "单人间", Selected = false },
                new SelectListItem { Text = "顶级单人间", Value = "顶级单人间", Selected = false },
                new SelectListItem { Text = "双人间", Value = "双人间", Selected = false },
                new SelectListItem { Text = "顶级双人间", Value = "顶级双人间", Selected = false },
                new SelectListItem { Text = "豪华套房", Value = "豪华套房", Selected = false },
                new SelectListItem { Text = "行政套房", Value = "行政套房", Selected = false },
                new SelectListItem { Text = "海景套房", Value = "海景套房", Selected = false },
                new SelectListItem { Text = "总统套房", Value = "总统套房", Selected = false }
            };
            ViewData["suiteType"] = suiteItemList;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}