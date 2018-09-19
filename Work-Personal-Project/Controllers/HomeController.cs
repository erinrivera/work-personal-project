﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work_Personal_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Your resume.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your portfolio.";

            return View();
        }
    }
}