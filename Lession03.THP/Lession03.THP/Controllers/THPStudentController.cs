using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession03.THP.Controllers
{
    public class THPStudentController : Controller
    {
        // GET: THPStudent
        public ActionResult Index()
        {
            // du lieu tu viewData
            ViewData["msg"] = "View Data - Trinh Huu Phuc";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }

        public ActionResult StudentList()
        {
            //Use viewBag
            //Luu tru gia tri don
            ViewBag.titleName = "Danh sach hoc vien - Trinh Phuc";

            //Gia tri la mot tap hop
            string[] names = { "Nam", "phuc", "linh" };
            ViewBag.list = names;

            //gia tri doi tuong
            var obj = new
            {
                ID = 100,
                Name = "phuc",
                Age = 20

            };
            ViewBag.student = obj;
            return View();  
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}
