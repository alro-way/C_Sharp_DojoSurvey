using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_DojoSurvey.Controllers
{
    public class OutputController : Controller  
    {
        [HttpPost]
        [Route("result")]
        public IActionResult Output(string name_on_subm, string local, string lang, string comment)
        {
            ViewBag.Output = "Cool! This is my OUTPUT!";
            ViewBag.Name = name_on_subm;
            ViewBag.Location =  local;
            ViewBag.Language = lang;
            ViewBag.Comm = comment; 
            return View("Output");
        }
    }
}