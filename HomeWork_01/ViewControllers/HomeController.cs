using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_01.ViewControllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      ViewBag.LessonName = Startup.Configuration["Logging:LessonName"];
      return View();
    }
  }
}
