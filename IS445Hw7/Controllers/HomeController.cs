﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445Hw7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult WebForm()
        {
            //ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult AboutMe()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
