﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class NotFound404Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
