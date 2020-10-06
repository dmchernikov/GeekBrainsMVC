using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork_01.Models;

namespace HomeWork_01.ViewControllers
{
  public class ProductController : Controller
  {
    public IActionResult List()
    {
      List<ViewModelProduct> data = ViewModelProduct.GetData();
      return View(data);
    }

    public IActionResult Details(int id)
    {
      List<ViewModelProduct> data = ViewModelProduct.GetData();
      var result = from item in data where item.Id == id select item;
      if(result.Count() == 0) return NotFound("Продукт по Id = " + id.ToString() + " - не найден.");
      return View(result.First());
    }
  }
}
