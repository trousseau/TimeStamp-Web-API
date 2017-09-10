using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timestamp_api.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/timestampapi")]
        public ActionResult APIHome()
        {
            return View();
        }
    }
}
