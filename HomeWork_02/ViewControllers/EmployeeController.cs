using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork_02.Models;

namespace HomeWork_02.ViewControllers
{
  public class EmployeeController : Controller
  {
    public IActionResult List()
    {
      List<ViewModelEmployee> data = ViewModelEmployee.GetData();
      return View(data);
    }

    public IActionResult Details(int id)
    {
      List<ViewModelEmployee> data = ViewModelEmployee.GetData();
      var result = from item in data where item.Id == id select item;
      if(result.Count() == 0) return NotFound("Сотрудник по Id = " + id.ToString() + " - не найден.");
      return View(result.First());
    }
  }
}
