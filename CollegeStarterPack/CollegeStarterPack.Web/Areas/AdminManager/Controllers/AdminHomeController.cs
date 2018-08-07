using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeStarterPack.Web.Areas.AdminManager.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminManager/AdminHome
        public ActionResult Index()
        {
            return View();
        }
    }
}