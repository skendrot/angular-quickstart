﻿using Models;
using Models.DAL;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WrapperExtensions;

namespace angularmvc.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}