using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_live_search.Controllers
{
    public class GetEmpController : Controller
    {
        // GET: GetEmp
        public ActionResult GetIndex()
        {
            Live_SearchEntities1 ls1 = new Live_SearchEntities1();
            ViewBag.employees = new SelectList(ls1.EmpDatas, "EmpId", "EmpName");

            return View();
        }
    }
}