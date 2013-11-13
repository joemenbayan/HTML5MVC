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

        public JsonResult SaveCanvas(string data)
        {
            Session["canvas_data"] = data;
            return Json("Canvas data stored successfully!");
        }

    }
}
