using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01a.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Bai1()
        {
            ViewBag.Message = "Tóm tắt bài báo";
            return View();
        }
        public ActionResult Bai2()
        {
            ViewBag.Message = "Hiển thị công thức";

            return View();
        }

        public ActionResult Bai3()
        {
            ViewBag.Message = "Tạo bảng";

            return View();
        }
    }
}