﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project_Admin.Views
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}