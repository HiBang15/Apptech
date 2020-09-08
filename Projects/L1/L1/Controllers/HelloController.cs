﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L1.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //return ActionResult View
        public IActionResult Index()
        {
            return View();
        }

        // 
        //// GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int id = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Name: {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
