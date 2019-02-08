using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult ShowText()
        {
      return Content("It is the ShowText() action. ");
    }
    public IActionResult ShowJSON()
    {
      return  Json(new {name="Favorite Place", quote="This is my favorite Place."});
    }
    public IActionResult ShowHTML()
    {
      var h = "<!DOCTYPE html><html><body>An awesome Place to visit is Los Angles. </body></html>";
      return Content(h, "text/html");
    }

    public IActionResult ShowView()
    {
      return View();
    }   
  }
}

