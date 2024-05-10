using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession02.THP.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Huu Phuc - 2210900054";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        public string GetName()
        {
            return "Trinh Huu Phuc - 2210900054";
        }

        public JsonResult ListName()
        {
            string[] names = { "hung", "dung", "sang" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}