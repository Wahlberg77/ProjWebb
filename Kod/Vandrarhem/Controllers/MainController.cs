using Db_Vandrarhem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vandrarhem.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            using (var ctx = new VandrarhemEntities())
            return View();
        }
    }
}