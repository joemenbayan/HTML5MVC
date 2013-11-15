using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML5.Models;

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

            ViewData["ListItems"] = items;

            
            return View();
        }

        public JsonResult SaveCanvas(string data)
        {
            Session["canvas_data"] = data;
            return Json("Canvas data stored successfully!");
        }

        public JsonResult Convert(TemperatureData t)
        {
            if (t.Unit == "C")
            {
                t.Value = (t.Value * 1.8m) + 32;
                t.Unit = "F";
            }
            else
            {
                t.Value = (t.Value - 32) / 1.8m;
                t.Unit = "C";
            }
            return Json(t, JsonRequestBehavior.AllowGet);
        }

    }
}
