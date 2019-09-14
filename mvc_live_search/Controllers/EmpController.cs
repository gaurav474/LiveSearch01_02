using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_live_search.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            Live_SearchEntities ls = new Live_SearchEntities();
            var data = ls.EmpDatas.ToList();
            ViewBag.result = data;
            return View();
        }
    }
}