﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model03_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //GET:Home/
        public ActionResult RedirDemo()
        {
            return RedirectToAction("Index");
        }
    }
}