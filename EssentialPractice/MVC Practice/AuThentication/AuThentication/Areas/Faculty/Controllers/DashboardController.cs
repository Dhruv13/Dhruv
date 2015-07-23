using AuThentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuThentication.Areas.Faculty.Controllers
{
    [Authorise(Roles="Faculty")]
    public class DashboardController : Controller
    {
        // GET: Faculty/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}