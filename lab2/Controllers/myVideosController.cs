﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class myVideosController : Controller
    {
        // GET: myVideos
        public ActionResult Index()
        {
            return View();
        }
    }
}