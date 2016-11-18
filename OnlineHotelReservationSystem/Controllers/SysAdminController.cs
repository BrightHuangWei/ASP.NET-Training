using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHotelReservationSystem.Controllers
{
    public class SysAdminController : Controller
    {
        // GET: SysAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SysAdminLogin()
        {
            return View();
        }
    }
}