using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_DojoSurvey.Controllers
{
    public class FormController : Controller  
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            ViewBag.Form = "Cool! This is my Form!";
            return View();
        }
    }
}