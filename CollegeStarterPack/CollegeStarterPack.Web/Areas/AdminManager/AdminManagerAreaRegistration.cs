using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeStarterPack.Web.Areas.AdminManager
{
    public class AdminManagerAreaRegistration: AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AdminManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AdminManager_default",
                "AdminManager/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}