using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML5.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Swimming", Value = "1" });
            items.Add(new SelectListItem { Text = "Cycling", Value = "2" });
            items.Add(new SelectListItem { Text = "Running", Value = "3" });

            return View();
        }

        public JsonResult SaveCanvas(string data)
        {
            Session["canvas_data"] = data;
            return Json("Canvas data stored successfully!");
        }

    }
}
