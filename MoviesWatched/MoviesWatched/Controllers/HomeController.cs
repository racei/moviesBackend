﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWatched.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return File(Server.MapPath("~/moviesFrontend/dist/") + "index.html", "text/html");
        }
    }
}
